using Environment = Alohi.Signplus.Http.Environment;

namespace Alohi.Signplus.Config;

/// <summary>
/// Per-request configuration overrides. When provided, these values take precedence
/// over method-level, service-level, and SDK-level configuration in that order.
/// </summary>
public record RequestConfig(
    /// <summary>Overrides the base URL for this request.</summary>
    string? BaseUrl = null,
    /// <summary>Overrides the environment for this request.</summary>
    Environment? Environment = null,
    /// <summary>Overrides the request timeout duration.</summary>
    TimeSpan? Timeout = null,
    /// <summary>Overrides the access token for this request.</summary>
    string? AccessToken = null,
    /// <summary>Overrides the retry configuration for this request.</summary>
    RetryConfig? RetryConfig = null
);
