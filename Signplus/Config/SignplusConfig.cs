using Environment = Signplus.Http.Environment;

namespace Signplus.Config;

/// <summary>
/// Configuration options for the SignplusClient.
/// </summary>
public record SignplusConfig(
    /// <value>The environment to use for the SDK.</value>
    Environment? Environment = null,
    /// <value>The access token.</value>
    string? AccessToken = null
);
