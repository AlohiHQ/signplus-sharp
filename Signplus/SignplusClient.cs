using Signplus.Config;
using Signplus.Http.Handlers;
using Signplus.Services;
using Environment = Signplus.Http.Environment;

namespace Signplus;

public class SignplusClient : IDisposable
{
    private readonly HttpClient _httpClient;
    private readonly TokenHandler _accessTokenHandler;

    public SignplusService Signplus { get; private set; }

    public SignplusClient(SignplusConfig? config = null)
    {
        var retryHandler = new RetryHandler();
        _accessTokenHandler = new TokenHandler(retryHandler)
        {
            Header = "Authorization",
            Prefix = "Bearer",
            Token = config?.AccessToken
        };

        _httpClient = new HttpClient(_accessTokenHandler)
        {
            BaseAddress = config?.Environment?.Uri ?? Environment.Default.Uri,
            DefaultRequestHeaders = { { "user-agent", "dotnet/7.0" } }
        };

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
    /// Sets the base URL for entire SDK.
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
        _httpClient.BaseAddress = uri;
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
