using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using Alohi.Signplus.Http.Extensions;
using Alohi.Signplus.Http.Serialization;

namespace Alohi.Signplus.Http;

/// <summary>
/// A builder for creating <see cref="HttpRequestMessage"/> instances with full support for serialization.
/// </summary>
public class RequestBuilder
{
    private readonly string _urlTemplate;

    private readonly HttpMethod _httpMethod;

    private readonly Dictionary<string, string> _pathParameters = new();
    private readonly List<string> _queryParameters = new();
    private readonly List<string> _cookieParameters = new();
    private readonly Dictionary<string, string> _headers = new();
    private readonly List<ErrorMapping> _errorMappings = new();
    private ErrorMapping? _defaultErrorMapping;

    private HttpContent? _content;

    /// <summary>
    /// Initializes a new instance of the <see cref="RequestBuilder"/> class.
    /// </summary>
    /// <param name="httpMethod">The HTTP method to use for the request.</param>
    /// <param name="urlTemplate">The URL template to use for the request. Should have path parameters as placeholders surrounded by brackets (Eg. "/users/{id}", where "id" is a path parameter).</param>
    public RequestBuilder(HttpMethod httpMethod, string urlTemplate)
    {
        _httpMethod = httpMethod;
        _urlTemplate = urlTemplate;
    }

    /// <summary>
    /// Sets a path parameter. If the parameter is not present in the URL template, it will be ignored.
    /// </summary>
    public RequestBuilder SetPathParameter(
        string key,
        object value,
        PathSerializationStyle style = PathSerializationStyle.Simple,
        bool explode = false
    )
    {
        var serializedValue = Serializer.Serialize(key, value, (SerializationStyle)style, explode);
        _pathParameters.Add(key, serializedValue);
        return this;
    }

    /// <summary>
    /// Sets a query parameter.
    /// </summary>
    public RequestBuilder SetQueryParameter(
        string key,
        object? value,
        QuerySerializationStyle style = QuerySerializationStyle.Form,
        bool explode = true
    )
    {
        var serializedValue = Serializer.Serialize(key, value, (SerializationStyle)style, explode);
        if (!string.IsNullOrEmpty(serializedValue))
        {
            _queryParameters.Add(serializedValue);
        }
        return this;
    }

    /// <summary>
    /// Sets a query parameter if the value is not null.
    /// </summary>
    public RequestBuilder SetOptionalQueryParameter(
        string key,
        object? value,
        QuerySerializationStyle style = QuerySerializationStyle.Form,
        bool explode = true
    )
    {
        if (value is not null)
        {
            SetQueryParameter(key, value, style, explode);
        }
        return this;
    }

    /// <summary>
    /// Sets a header.
    /// </summary>
    public RequestBuilder SetHeader(string key, object? value, bool explode = false)
    {
        var serializedValue = Serializer.Serialize(
            key,
            value,
            SerializationStyle.Simple,
            explode,
            false
        );
        if (!string.IsNullOrEmpty(serializedValue))
        {
            _headers.Add(key, serializedValue);
        }
        return this;
    }

    /// <summary>
    /// Sets a header if the value is not null.
    /// </summary>
    public RequestBuilder SetOptionalHeader(string key, object? value, bool explode = false)
    {
        if (value is not null)
        {
            SetHeader(key, value, explode);
        }
        return this;
    }

    /// <summary>
    /// Sets a cookie parameter. Multiple calls accumulate cookies combined into a single Cookie header.
    /// Arrays with explode=true produce separate name=value pairs (e.g. "key=v1; key=v2").
    /// Arrays with explode=false produce a comma-separated list (e.g. "key=v1,v2,v3").
    /// </summary>
    public RequestBuilder SetCookieParameter(string key, object? value, bool explode = true)
    {
        var serialized = Serializer.Serialize(key, value, SerializationStyle.Form, explode, false);
        if (!string.IsNullOrEmpty(serialized))
        {
            _cookieParameters.AddRange(serialized.Split('&'));
        }
        return this;
    }

    /// <summary>
    /// Sets a cookie parameter if the value is not null.
    /// </summary>
    public RequestBuilder SetOptionalCookieParameter(string key, object? value, bool explode = true)
    {
        if (value is not null)
        {
            SetCookieParameter(key, value, explode);
        }
        return this;
    }

    /// <summary>
    /// Sets the content of the request as JSON.
    /// </summary>
    public RequestBuilder SetContentAsJson(
        object content,
        JsonSerializerOptions? options = null,
        MediaTypeHeaderValue? mediaType = null
    )
    {
        _content = JsonContent.Create(content, mediaType, options);
        return this;
    }

    /// <summary>
    /// Sets the content of the request as Text.
    /// </summary>
    public RequestBuilder SetContentAsText(
        string content,
        string mediaType,
        Encoding? encoding = null
    )
    {
        encoding ??= Encoding.UTF8;
        _content = new StringContent(content, encoding, mediaType);
        return this;
    }

    /// <summary>
    /// Sets the content of the request as Binary.
    /// </summary>
    public RequestBuilder SetContentAsBinary(byte[] content, MediaTypeHeaderValue mediaType)
    {
        _content = new ByteArrayContent(content);
        _content.Headers.ContentType = mediaType;
        return this;
    }

    /// <summary>
    /// Sets the content of the request as application/x-www-form-urlencoded.
    /// </summary>
    public RequestBuilder SetUrlEncodedContent(
        object content,
        JsonSerializerOptions? options = null
    )
    {
        var jsonContent = JsonSerializer.Serialize(content, options);
        var dictionary = JsonSerializer.Deserialize<Dictionary<string, string>>(
            jsonContent,
            options
        );

        if (dictionary is null)
        {
            throw new ArgumentException("Invalid content for form-urlencoded content type.");
        }

        _content = new FormUrlEncodedContent(dictionary);
        return this;
    }

    /// <summary>
    /// Sets the content of the request as multipart/form-data.
    /// </summary>
    public RequestBuilder SetContentAsMultipartFormData(
        object content,
        JsonSerializerOptions? options = null
    )
    {
        _content = new MultipartFormDataContent().AddObject(content, options);
        return this;
    }

    private string BuildUrl()
    {
        var url = _urlTemplate;
        foreach (var (key, value) in _pathParameters)
        {
            url = url.Replace($"{{{key}}}", value);
        }

        if (_queryParameters.Any())
        {
            url += "?" + string.Join("&", _queryParameters);
        }

        return url;
    }

    /// <summary>
    /// Adds a mapping between an HTTP status code/content type combination and the corresponding error model and exception type.
    /// </summary>
    /// <param name="statusCode">The HTTP status code to map (e.g., 400, 404, 500).</param>
    /// <param name="contentType">The content type of the error response (e.g., "application/json").</param>
    /// <param name="targetType">The type to deserialize the error response body into.</param>
    /// <param name="exceptionType">The exception type to throw when this error occurs. Must extend Exception.</param>
    public RequestBuilder AddError(
        int statusCode,
        string contentType,
        Type targetType,
        Type exceptionType
    )
    {
        var errorMapping = new ErrorMapping
        {
            StatusCode = statusCode,
            ContentType = contentType,
            TargetType = targetType,
            ExceptionType = exceptionType,
        };

        if (statusCode == Request.NoStatusCode)
        {
            _defaultErrorMapping = errorMapping;
        }
        else
        {
            _errorMappings.Add(errorMapping);
        }

        return this;
    }

    /// <summary>
    ///  Sets the default error mapping to be thrown when no other error can be matched
    /// </summary>
    public RequestBuilder AddDefaultError(string contentType, Type targetType, Type exceptionType)
    {
        return AddError(Request.NoStatusCode, contentType, targetType, exceptionType);
    }

    /// <summary>
    /// Builds the <see cref="HttpRequestMessage"/> instance.
    /// </summary>
    public HttpRequestMessage BuildHttpRequestMessage()
    {
        var requestMessage = new HttpRequestMessage(_httpMethod, BuildUrl()) { Content = _content };

        foreach (var (key, value) in _headers)
        {
            requestMessage.Headers.Add(key, value);
        }

        if (_cookieParameters.Count > 0)
        {
            requestMessage.Headers.Add("Cookie", string.Join("; ", _cookieParameters));
        }

        return requestMessage;
    }

    /// <summary>
    /// Builds the <see cref="Request"/> object containing all request information.
    /// </summary>
    public Request Build()
    {
        return new Request
        {
            Url = BuildUrl(),
            HttpMethod = _httpMethod,
            Headers = new Dictionary<string, string>(_headers),
            Content = _content,
            ErrorMappings = new List<ErrorMapping>(_errorMappings),
            DefaultErrorMapping = _defaultErrorMapping,
            HttpRequestMessage = BuildHttpRequestMessage(),
        };
    }
}
