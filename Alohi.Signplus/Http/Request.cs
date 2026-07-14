using System.Net.Http;

namespace Alohi.Signplus.Http;

/// <summary>
/// A record that holds all the information needed to make an HTTP request.
/// </summary>
public record Request
{
    /// <summary>
    /// The URL for the request.
    /// </summary>
    public string Url { get; init; }

    /// <summary>
    /// The HTTP method for the request.
    /// </summary>
    public HttpMethod HttpMethod { get; init; }

    /// <summary>
    /// The headers for the request.
    /// </summary>
    public Dictionary<string, string> Headers { get; init; }

    /// <summary>
    /// The content of the request.
    /// </summary>
    public HttpContent? Content { get; init; }

    /// <summary>
    /// List of error mappings that define how to handle specific HTTP status codes and content types.
    /// </summary>
    public List<ErrorMapping> ErrorMappings { get; init; }

    /// <summary>
    /// Default error mapping used when no specific error can be matched.
    /// </summary>
    public ErrorMapping? DefaultErrorMapping { get; init; }

    /// <summary>
    /// Constant representing the absence of a specific HTTP status code, used for default error mappings.
    /// </summary>
    public const int NoStatusCode = 0;

    /// <summary>
    /// HttpRequestMessage that can be directly passed to a C# HttpClient.
    /// </summary>
    public HttpRequestMessage HttpRequestMessage { get; init; }
}
