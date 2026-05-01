namespace Alohi.Signplus.Http.Exceptions;

/// <summary>
/// Exception thrown when an API request receives a non-successful HTTP status code.
/// Wraps the HTTP response to provide access to the full error details including status code, headers, and body.
/// </summary>
public class ApiException : HttpRequestException
{
    /// <summary>
    /// Gets the HTTP response message that triggered this exception.
    /// Provides access to status code, headers, and response body for error handling.
    /// </summary>
    public HttpResponseMessage Response { get; }

    public ApiException(HttpResponseMessage responseMessage)
        : base(
            $"Response status code does not indicate success: {(int)responseMessage.StatusCode} ({responseMessage.StatusCode}).",
            null,
            responseMessage.StatusCode
        )
    {
        Response = responseMessage;
    }
}
