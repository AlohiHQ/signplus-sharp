namespace Alohi.Signplus.Config;

/// <summary>
/// Retry configuration for SDK requests.
/// </summary>
public record RetryConfig(
    /// <summary>The maximum number of retry attempts.</summary>
    int? MaxRetryAttempts = null,
    /// <summary>The initial delay between retries.</summary>
    TimeSpan? Delay = null,
    /// <summary>The maximum delay cap between retries.</summary>
    TimeSpan? MaxDelay = null,
    /// <summary>The backoff multiplier applied to the delay on each retry attempt.</summary>
    double? BackoffMultiplier = null,
    /// <summary>Whether to add random jitter to the retry delay.</summary>
    bool? UseJitter = null,
    /// <summary>Specific HTTP status codes to retry. When null, retries all 5xx, 408, and 429 responses.</summary>
    IReadOnlyList<int>? RetryableStatusCodes = null,
    /// <summary>HTTP methods eligible for retry.</summary>
    IReadOnlyList<string>? RetryableHttpMethods = null
);
