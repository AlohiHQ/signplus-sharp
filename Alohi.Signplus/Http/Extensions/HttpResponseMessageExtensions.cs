using Alohi.Signplus.Http.Exceptions;

namespace Alohi.Signplus.Http.Extensions;

/// <summary>
/// Extension methods for HttpResponseMessage to add custom validation and error handling.
/// </summary>
public static class HttpResponseMessageExtensions
{
    /// <summary>
    /// Ensures the HTTP response has a successful status code (2xx), throwing ApiException if not.
    /// Provides more control than the built-in EnsureSuccessStatusCode by throwing a custom exception type.
    /// </summary>
    /// <param name="response">The HTTP response to validate.</param>
    /// <returns>The same response if successful, for method chaining.</returns>
    /// <exception cref="ApiException">Thrown when the response status code indicates failure.</exception>
    public static HttpResponseMessage EnsureSuccessfulResponse(this HttpResponseMessage response)
    {
        if (!response.IsSuccessStatusCode)
        {
            throw new ApiException(response);
        }
        return response;
    }
}
