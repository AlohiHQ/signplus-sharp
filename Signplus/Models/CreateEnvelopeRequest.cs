using System.Text.Json.Serialization;

namespace Signplus.Models;

public record CreateEnvelopeRequest(
    /// <value>Name of the envelope</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Name = null,
    /// <value>Flow type of the envelope (REQUEST_SIGNATURE is a request for signature, SIGN_MYSELF is a self-signing flow)</value>
    [property:
        JsonPropertyName("flow_type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        EnvelopeFlowType? FlowType = null,
    /// <value>Legal level of the envelope (SES is Simple Electronic Signature, QES_EIDAS is Qualified Electronic Signature, QES_ZERTES is Qualified Electronic Signature with Zertes)</value>
    [property:
        JsonPropertyName("legality_level"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        EnvelopeLegalityLevel? LegalityLevel = null,
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
