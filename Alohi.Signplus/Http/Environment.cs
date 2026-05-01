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
        Uri = new Uri(uri);
    }

    public static Environment Default { get; } = new("https://restapi.sign.plus/v2/");
    public static Environment Restapi { get; } = new("https://restapi.sign.plus/v2/");
}
