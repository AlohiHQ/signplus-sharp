namespace Alohi.Signplus.Http.Exceptions;

public class ApiException : HttpRequestException
{
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
