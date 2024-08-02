using System.Text.Json.Serialization;

namespace Signplus.Models;

public record SetEnvelopeExpirationRequest(
    /// <value>Unix timestamp of the expiration date</value>
    [property: JsonPropertyName("expires_at")]
        long ExpiresAt
);
