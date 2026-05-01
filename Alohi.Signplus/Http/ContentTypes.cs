namespace Alohi.Signplus.Http;

public static class ContentTypes
{
    public const string ApplicationJson = "application/json";
    public const string TextJson = "text/json";
    public const string ApplicationOctetStream = "application/octet-stream";
    public const string ApplicationPdf = "application/pdf";
    public const string FormUrlEncoded = "application/x-www-form-urlencoded";
    public const string MultipartFormData = "multipart/form-data";
    public const string Wildcard = "*/*";
    public const string ApplicationXML = "application/xml";
    public const string TextXML = "text/xml";

    public static bool IsJson(string contentType)
    {
        if (string.IsNullOrEmpty(contentType))
        {
            return false;
        }

        switch (contentType)
        {
            case ApplicationJson:
            case TextJson:
            case MultipartFormData: // currently handled as JSON inside c#
                return true;
            default:
                return false;
        }
    }

    public static bool IsText(string contentType)
    {
        if (string.IsNullOrEmpty(contentType))
        {
            return false;
        }

        switch (contentType)
        {
            case TextJson:
                return false;
            case ApplicationXML:
            case TextXML:
            case FormUrlEncoded:
                return true;
            default:
                if (contentType.StartsWith("text/"))
                {
                    return true;
                }
                return false;
        }
    }

    public static bool IsBinary(string contentType)
    {
        if (string.IsNullOrEmpty(contentType))
        {
            return false;
        }

        if (contentType.StartsWith("image/"))
        {
            return true;
        }

        switch (contentType)
        {
            case ApplicationOctetStream:
            case ApplicationPdf:
            case Wildcard:
                return true;
            default:
                return false;
        }
    }

    /// <summary>
    /// Matches an expected content type pattern against an actual content type.
    /// Handles wildcards (e.g., "application/*" or "*/*") and charset variations
    /// (e.g., "application/json; charset=utf-8").
    /// </summary>
    /// <param name="expected">The expected content type pattern</param>
    /// <param name="actual">The actual content type from the response</param>
    /// <returns>True if the content types match, false otherwise</returns>
    public static bool Matches(string expected, string actual)
    {
        // Both empty or null - consider it a match
        if (string.IsNullOrEmpty(expected) && string.IsNullOrEmpty(actual))
        {
            return true;
        }

        // One is empty/null and the other isn't - no match
        if (string.IsNullOrEmpty(expected) || string.IsNullOrEmpty(actual))
        {
            return false;
        }

        // Handle wildcard patterns like "application/*" or "*/*"
        if (expected.EndsWith("/*"))
        {
            var prefix = expected.Substring(0, expected.Length - 2);

            // "*/*" matches everything
            if (prefix == "*")
            {
                return true;
            }

            // Strip charset from actual if present
            var actualBase = actual.Split(';')[0].Trim();
            return actualBase.StartsWith(prefix + "/", StringComparison.OrdinalIgnoreCase);
        }

        // Handle charset and parameter variations
        // e.g., "application/json; charset=utf-8" should match "application/json"
        var actualBasePart = actual.Split(';')[0].Trim();
        var expectedBasePart = expected.Split(';')[0].Trim();

        return string.Equals(actualBasePart, expectedBasePart, StringComparison.OrdinalIgnoreCase);
    }
}
