using Alohi.Signplus.Config;
using Alohi.Signplus.Http;
using Alohi.Signplus.Http.Extensions;
using Alohi.Signplus.Http.Handlers;
using Alohi.Signplus.Services;
using Environment = Alohi.Signplus.Http.Environment;

namespace Alohi.Signplus;

/// <summary>
/// The main SDK client that provides access to all service endpoints.
/// Manages HTTP client lifecycle, authentication handlers, and service instances with centralized configuration.
/// Implements IDisposable to properly clean up HTTP resources.
/// </summary>
public class SignplusClient : IDisposable
{
    private readonly Client _httpClient;

    private readonly TokenHandler _accessTokenHandler;

    public SignplusService Signplus { get; private set; }

    /// <summary>Initializes a new instance of the SignplusClient client.</summary>
    /// <param name="config">SDK configuration options.</param>
    public SignplusClient(SignplusConfig? config = null)
    {
        var retryHandler = new RetryHandler();
        _accessTokenHandler = new TokenHandler(retryHandler)
        {
            Header = "Authorization",
            Prefix = "Bearer",
            Token = config?.AccessToken,
            OverrideTokenOptionsKey = "_RequestConfig_OverrideAccessToken",
        };

        _httpClient = new Client(config, _accessTokenHandler);

        Signplus = new SignplusService(_httpClient);
    }

    /// <summary>
    /// Set the environment for the entire SDK.
    /// </summary>
    public void SetEnvironment(Environment environment)
    {
        SetBaseUrl(environment.Uri);
    }

    /// <summary>
    /// Sets the base URL for the entire SDK.
    /// </summary>
    public void SetBaseUrl(string baseUrl)
    {
        SetBaseUrl(new Uri(baseUrl));
    }

    /// <summary>
    /// Sets the base URL for the entire SDK.
    /// </summary>
    public void SetBaseUrl(Uri uri)
    {
        _httpClient.SetBaseAddress(uri.EnsureTrailingSlash());
    }

    /// <summary>
    /// Sets the timeout for the entire SDK.
    /// </summary>
    /// <param name="timeout">The timeout value. Must be a positive TimeSpan or Timeout.InfiniteTimeSpan.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the timeout is not valid.</exception>
    public void SetTimeout(TimeSpan timeout)
    {
        if (timeout <= TimeSpan.Zero && timeout != Timeout.InfiniteTimeSpan)
        {
            throw new ArgumentOutOfRangeException(
                nameof(timeout),
                "Timeout must be a positive value or Timeout.InfiniteTimeSpan."
            );
        }

        _httpClient.SetTimeout(timeout);
    }

    /// <summary>
    /// Sets the access token for the entire SDK.
    /// </summary>
    public void SetAccessToken(string token)
    {
        _accessTokenHandler.Token = token;
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}

// c029837e0e474b76bc487506e8799df5e3335891efe4fb02bda7a1441840310c
