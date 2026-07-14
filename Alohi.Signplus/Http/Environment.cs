namespace Alohi.Signplus.Http;

using Alohi.Signplus.Http.Extensions;

/// <summary>
/// The environments available for the SDK.
/// </summary>
public class Environment
{
    internal Uri Uri { get; private set; }
    internal string OriginalString { get; private set; }

    private Environment(string uri)
    {
        OriginalString = uri;
        Uri = TryParseEnvironmentUri(uri);
    }

    private static Uri TryParseEnvironmentUri(string uri)
    {
        // Server URLs in real specs sometimes contain non-URI placeholders
        // (Postman `{{var}}`, unresolved OpenAPI server variables, bracketed
        // tokens like `[Base_URL]`). Without this guard `new Uri(...)` throws
        // at static init time and prevents callers from even instantiating
        // the SDK to call `SetBaseUrl(...)`. Fall back to a clearly-invalid
        // sentinel so construction succeeds; the user gets a clean
        // unreachable-host error if they forget to set a real base URL.
        return Uri.TryCreate(uri, UriKind.Absolute, out var parsed)
            ? parsed
            : new Uri("https://invalid.example/");
    }

    public static Environment Default { get; } = new("https://restapi.sign.plus/v2/");
}
