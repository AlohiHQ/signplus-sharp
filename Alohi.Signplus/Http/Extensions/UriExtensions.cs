namespace Alohi.Signplus.Http.Extensions;

/// <summary>
/// Extension methods for Uri to manipulate URI formatting.
/// </summary>
public static class UriExtensions
{
    /// <summary>
    /// Ensures a URI ends with a trailing slash by appending one if not present.
    /// Useful for base URLs that need consistent trailing slashes for proper relative path resolution.
    /// </summary>
    /// <param name="uri">The URI to process.</param>
    /// <returns>A new URI with a guaranteed trailing slash.</returns>
    /// <exception cref="ArgumentNullException">Thrown when uri is null.</exception>
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
