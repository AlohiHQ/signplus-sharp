using System.Collections.Concurrent;
using System.Net;
using Alohi.Signplus.Config;
using Polly;
using Polly.Retry;

namespace Alohi.Signplus.Http.Handlers;

/// <summary>
/// A handler for retrying requests when they fail.
/// </summary>
public class RetryHandler : DelegatingHandler
{
    private static readonly HttpRequestOptionsKey<RetryConfig> RetryConfigKey =
        new HttpRequestOptionsKey<RetryConfig>("_RequestConfig_RetryConfig");

    private readonly int _defaultMaxRetryAttempts = 3;
    private readonly TimeSpan _defaultDelay = TimeSpan.FromMilliseconds(150);
    private readonly TimeSpan _defaultMaxDelay = TimeSpan.FromMilliseconds(5000);
    private readonly double _defaultBackoffMultiplier = 2;
    private readonly bool _defaultUseJitter = true;
    private readonly HashSet<string> _defaultRetryableHttpMethods = new HashSet<string>(
        StringComparer.OrdinalIgnoreCase
    )
    {
        "GET",
        "POST",
        "PUT",
        "DELETE",
        "PATCH",
        "HEAD",
        "OPTIONS",
    };

    private readonly ResiliencePipeline<HttpResponseMessage> _defaultPipeline;
    private readonly ConcurrentDictionary<
        RetryConfig,
        ResiliencePipeline<HttpResponseMessage>
    > _pipelineCache = new();

    public RetryHandler(HttpMessageHandler? innerHandler = null)
        : base(innerHandler ?? new HttpClientHandler())
    {
        _defaultPipeline = BuildPipeline(null);
    }

    private static bool ShouldRetryStatus(HttpStatusCode statusCode, HashSet<int>? specificCodes)
    {
        if (specificCodes != null)
            return specificCodes.Contains((int)statusCode);

        return (int)statusCode >= 500
            || statusCode == HttpStatusCode.RequestTimeout
            || statusCode == HttpStatusCode.TooManyRequests;
    }

    private ResiliencePipeline<HttpResponseMessage> BuildPipeline(RetryConfig? overrideConfig)
    {
        var maxRetryAttempts = overrideConfig?.MaxRetryAttempts ?? _defaultMaxRetryAttempts;
        var delay = overrideConfig?.Delay ?? _defaultDelay;
        var maxDelay = overrideConfig?.MaxDelay ?? _defaultMaxDelay;
        var backoffMultiplier = overrideConfig?.BackoffMultiplier ?? _defaultBackoffMultiplier;
        var useJitter = overrideConfig?.UseJitter ?? _defaultUseJitter;
        HashSet<int>? specificCodes =
            overrideConfig?.RetryableStatusCodes != null
                ? new HashSet<int>(overrideConfig.RetryableStatusCodes)
                : null;

        return new ResiliencePipelineBuilder<HttpResponseMessage>()
            .AddRetry(
                new RetryStrategyOptions<HttpResponseMessage>()
                {
                    MaxRetryAttempts = maxRetryAttempts,
                    ShouldHandle = (args) =>
                    {
                        var response = args.Outcome.Result;
                        if (response is null)
                            return ValueTask.FromResult(false);
                        return ValueTask.FromResult(
                            ShouldRetryStatus(response.StatusCode, specificCodes)
                        );
                    },
                    DelayGenerator = (args) =>
                    {
                        var exponentialMs =
                            delay.TotalMilliseconds
                            * Math.Pow(backoffMultiplier, args.AttemptNumber);
                        if (useJitter)
                        {
                            var jitterFactor = 1.0 + (Random.Shared.NextDouble() - 0.5) * 0.5;
                            exponentialMs *= jitterFactor;
                        }
                        var cappedMs = Math.Min(exponentialMs, maxDelay.TotalMilliseconds);
                        return new ValueTask<TimeSpan?>(TimeSpan.FromMilliseconds(cappedMs));
                    },
                }
            )
            .Build();
    }

    protected override async Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken
    )
    {
        request.Options.TryGetValue(RetryConfigKey, out var retryConfig);

        var retryableHttpMethods =
            retryConfig?.RetryableHttpMethods != null
                ? new HashSet<string>(
                    retryConfig.RetryableHttpMethods,
                    StringComparer.OrdinalIgnoreCase
                )
                : _defaultRetryableHttpMethods;

        if (!retryableHttpMethods.Contains(request.Method.Method))
        {
            return await base.SendAsync(request, cancellationToken);
        }

        if (retryConfig?.MaxRetryAttempts == 0)
        {
            return await base.SendAsync(request, cancellationToken);
        }

        var pipeline = retryConfig is null
            ? _defaultPipeline
            : _pipelineCache.GetOrAdd(retryConfig, BuildPipeline);
        return await pipeline.ExecuteAsync<HttpResponseMessage>(
            async (token) => await base.SendAsync(request, token),
            cancellationToken
        );
    }
}
