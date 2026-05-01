using System.Text.Json;
using Alohi.Signplus.Config;
using Alohi.Signplus.Http;
using Alohi.Signplus.Http.Exceptions;
using Alohi.Signplus.Models;

namespace Alohi.Signplus.Services;

/// <summary>
/// Base service class providing core HTTP request execution and JSON serialization for all service endpoints.
/// </summary>
public class BaseService
{
    /// <summary>
    /// Constant representing the absence of a specific HTTP status code, used for default error mappings.
    /// </summary>
    protected const int NoStatusCode = 0;

    protected readonly Client _httpClient;
    protected readonly JsonSerializerOptions _jsonSerializerOptions;
    private RequestConfig? _serviceConfig;

    public BaseService(Client httpClient)
    {
        _httpClient = httpClient;
        _jsonSerializerOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web);
        _jsonSerializerOptions.Converters.Add(new OptionalConverterFactory());
    }

    /// <summary>
    /// Sets service-level configuration that applies to all methods in this service.
    /// Service-level config is overridden by method-level and request-level config.
    /// </summary>
    public BaseService SetConfig(RequestConfig config)
    {
        _serviceConfig = config;
        return this;
    }

    /// <summary>
    /// Resolves configuration by merging service, method, and request configs.
    /// Priority order (highest to lowest): request config > method config > service config > SDK config.
    /// </summary>
    protected RequestConfig? GetResolvedConfig(
        RequestConfig? methodConfig,
        RequestConfig? requestConfig
    )
    {
        if (_serviceConfig == null && methodConfig == null && requestConfig == null)
        {
            return null;
        }

        return new RequestConfig(
            BaseUrl: requestConfig?.BaseUrl ?? methodConfig?.BaseUrl ?? _serviceConfig?.BaseUrl,
            Environment: requestConfig?.Environment
                ?? methodConfig?.Environment
                ?? _serviceConfig?.Environment,
            Timeout: requestConfig?.Timeout ?? methodConfig?.Timeout ?? _serviceConfig?.Timeout,
            AccessToken: requestConfig?.AccessToken
                ?? methodConfig?.AccessToken
                ?? _serviceConfig?.AccessToken,
            RetryConfig: requestConfig?.RetryConfig
                ?? methodConfig?.RetryConfig
                ?? _serviceConfig?.RetryConfig
        );
    }

    /// <summary>
    /// Executes an HTTP request, applying any per-request configuration overrides.
    /// </summary>
    /// <param name="request">The HTTP request message to send.</param>
    /// <param name="resolvedConfig">Optional resolved configuration with per-request overrides.</param>
    /// <param name="cancellationToken">Optional cancellation token to cancel the operation.</param>
    /// <returns>The HTTP response message if the request succeeds.</returns>
    protected async Task<HttpResponseMessage> ExecuteAsync(
        Request request,
        RequestConfig? resolvedConfig = null,
        CancellationToken cancellationToken = default
    )
    {
        CancellationTokenSource? timeoutCts = null;

        try
        {
            if (resolvedConfig?.Timeout != null)
            {
                timeoutCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
                timeoutCts.CancelAfter(resolvedConfig.Timeout.Value);
                cancellationToken = timeoutCts.Token;
            }

            ApplyRequestConfigOverrides(request, resolvedConfig);

            var response = await _httpClient
                .SendAsync(request, cancellationToken)
                .ConfigureAwait(false);
            return response;
        }
        finally
        {
            // Safe to dispose here: SendAsync has completed and the response body
            // is buffered by the time we return. Streaming requests use a separate
            // ExecuteStreamAsync path and are not affected.
            timeoutCts?.Dispose();
        }
    }

    /// <summary>
    /// Applies BaseUrl and authentication overrides from the resolved config to the outgoing request.
    /// BaseUrl is applied by rewriting the request URI; auth overrides are passed via request options
    /// so that the delegating handlers in the pipeline can apply them instead of their stored credentials.
    /// </summary>
    private static void ApplyRequestConfigOverrides(Request request, RequestConfig? resolvedConfig)
    {
        if (resolvedConfig == null)
            return;

        if (resolvedConfig.BaseUrl != null)
        {
            var baseUri = new Uri(resolvedConfig.BaseUrl.TrimEnd('/') + "/");
            request.HttpRequestMessage.RequestUri = new Uri(baseUri, request.Url);
        }

        if (resolvedConfig.AccessToken != null)
        {
            request.HttpRequestMessage.Options.Set(
                new HttpRequestOptionsKey<string>("_RequestConfig_OverrideAccessToken"),
                resolvedConfig.AccessToken
            );
        }
        if (resolvedConfig.RetryConfig != null)
        {
            request.HttpRequestMessage.Options.Set(
                new HttpRequestOptionsKey<RetryConfig>("_RequestConfig_RetryConfig"),
                resolvedConfig.RetryConfig
            );
        }
    }
}
