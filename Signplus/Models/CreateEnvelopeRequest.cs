using System.Text.Json.Serialization;

namespace Signplus.Models;

public record CreateEnvelopeRequest(
    /// <value>Name of the envelope</value>
    [property: JsonPropertyName("name")]
        string Name,
    /// <value>Legal level of the envelope (SES is Simple Electronic Signature, QES_EIDAS is Qualified Electronic Signature, QES_ZERTES is Qualified Electronic Signature with Zertes)</value>
    [property: JsonPropertyName("legality_level")]
        EnvelopeLegalityLevel LegalityLevel,
    /// <value>Unix timestamp of the expiration date</value>
    [property:
        JsonPropertyName("expires_at"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? ExpiresAt = null,
    /// <value>Comment for the envelope</value>
    [property:
        JsonPropertyName("comment"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Comment = null,
    /// <value>Whether the envelope is created in sandbox mode</value>
    [property:
        JsonPropertyName("sandbox"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Sandbox = null
);
