using System.Text.Json;
using Alohi.Signplus.Config;
using Alohi.Signplus.Http.Exceptions;
using Alohi.Signplus.Models;

namespace Alohi.Signplus.Http;

public class Client
{
    private HttpClient _httpClient;

    private static readonly JsonSerializerOptions _errorSerializerOptions =
        CreateErrorSerializerOptions();

    private static JsonSerializerOptions CreateErrorSerializerOptions()
    {
        var options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
        options.Converters.Add(new OptionalConverterFactory());
        return options;
    }

    public Client(SignplusConfig config, HttpMessageHandler? handler = null)
    {
        _httpClient = handler == null ? new HttpClient() : new HttpClient(handler);
        _httpClient.BaseAddress = config?.Environment?.Uri ?? Environment.Default.Uri;
        _httpClient.DefaultRequestHeaders.Add(
            "user-agent",
            "postman-codegen/1.1.2 Alohi.Signplus/3.0.0 (csharp)"
        );
    }

    public void SetBaseAddress(Uri uri)
    {
        _httpClient.BaseAddress = uri;
    }

    public void SetTimeout(TimeSpan timeout)
    {
        _httpClient.Timeout = timeout;
    }

    public async Task<HttpResponseMessage> SendAsync(
        Request request,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _httpClient
            .SendAsync(request.HttpRequestMessage, cancellationToken)
            .ConfigureAwait(false);
        await HandleError(request, response);
        return response;
    }

    public async Task<HttpResponseMessage> SendAsync(
        Request request,
        HttpCompletionOption httpCompletionOptions,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _httpClient
            .SendAsync(request.HttpRequestMessage, httpCompletionOptions, cancellationToken)
            .ConfigureAwait(false);
        await HandleError(request, response);
        return response;
    }

    /// <summary>
    /// Handles error responses by checking configured error mappings and throwing appropriate exceptions.
    /// </summary>
    /// <param name="response">The HTTP response message to check for errors.</param>
    /// <exception cref="HttpRequestException">Thrown when the request fails and no matching error mapping is found, or when deserialization fails.</exception>
    /// <exception cref="Exception">Throws a specific exception type based on configured error mappings when a matching status code and content type is found.</exception>
    private async Task HandleError(Request request, HttpResponseMessage response)
    {
        if (response.IsSuccessStatusCode)
        {
            return; // No error to handle
        }

        var statusCode = (int)response.StatusCode;
        var contentType = response.Content.Headers.ContentType?.MediaType ?? string.Empty;

        var mapping = request.ErrorMappings?.FirstOrDefault(m =>
            m.StatusCode == statusCode && ContentTypes.Matches(m.ContentType, contentType)
        );

        if (mapping != null)
        {
            await DeserializeAndThrowException(response, mapping);
        }

        if (request.DefaultErrorMapping != null)
        {
            await DeserializeAndThrowException(response, request.DefaultErrorMapping);
        }

        throw new ApiException(response);
    }

    /// <summary>
    /// Deserializes a given exception and throws it
    /// </summary>
    /// <param name="response">The HTTP response message to check for errors.</param>
    /// <param name="mapping">The error mapping to use for deserialization and exception creation.</param>
    /// <exception cref="Exception">Throws a specific exception type based on the provided error mapping.</exception>
    private async Task DeserializeAndThrowException(
        HttpResponseMessage response,
        ErrorMapping mapping
    )
    {
        // TODO USE DESERIALIZATION LOGIC which will catch the case where we have non-json responses
        var contentString = await response.Content.ReadAsStringAsync();
        try
        {
            var deserializedError = JsonSerializer.Deserialize(
                contentString,
                mapping.TargetType,
                _errorSerializerOptions
            );

            if (deserializedError == null)
            {
                throw new ApiException(response);
            }
            var exception = (Exception)
                Activator.CreateInstance(
                    mapping.ExceptionType,
                    new object[] { deserializedError, response }
                )!;
            throw exception;
        }
        catch (JsonException)
        {
            throw new ApiException(response);
        }
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}
