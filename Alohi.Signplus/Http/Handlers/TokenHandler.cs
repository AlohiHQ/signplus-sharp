namespace Alohi.Signplus.Http.Handlers;

/// <summary>
/// A handler for adding a token to the request.
/// </summary>
public class TokenHandler : DelegatingHandler
{
    public string? Token { get; set; }
    public string? Header { get; set; } = "Authorization";
    public string Prefix { get; init; } = "Bearer";
    public string? OverrideTokenOptionsKey { get; init; }

    public TokenHandler(HttpMessageHandler? innerHandler = null)
        : base(innerHandler ?? new HttpClientHandler()) { }

    protected override Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken
    )
    {
        string? effectiveToken = Token;
        string? effectiveHeader = Header;

        if (
            OverrideTokenOptionsKey is not null
            && request.Options.TryGetValue(
                new HttpRequestOptionsKey<string>(OverrideTokenOptionsKey),
                out var overrideToken
            )
        )
        {
            effectiveToken = overrideToken;
        }

        if (
            request.Options.TryGetValue(
                new HttpRequestOptionsKey<string>("_RequestConfig_OverrideHeader"),
                out var overrideHeader
            )
        )
        {
            effectiveHeader = overrideHeader;
        }

        if (effectiveToken is not null && effectiveHeader is not null)
        {
            if (request.Headers.Contains(effectiveHeader))
                request.Headers.Remove(effectiveHeader);
            request.Headers.Add(effectiveHeader, $"{Prefix} {effectiveToken}");
        }

        return base.SendAsync(request, cancellationToken);
    }
}
