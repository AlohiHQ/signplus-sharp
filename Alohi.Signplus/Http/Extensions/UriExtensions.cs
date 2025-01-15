namespace Alohi.Signplus.Http.Extensions;

public static class UriExtensions
{
    public static Uri EnsureTrailingSlash(this Uri uri)
    {
        if (uri == null)
            throw new ArgumentNullException(nameof(uri));

        var uriString = uri.ToString();
        if (!uriString.EndsWith("/"))
        {
            uriString += "/";
        }

        return new Uri(uriString);
    }
}
