using System.Text.Json.Serialization;

namespace Signplus.Models;

public record Envelope(
    /// <value>Unique identifier of the envelope</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>Name of the envelope</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Name = null,
    /// <value>Comment for the envelope</value>
    [property:
        JsonPropertyName("comment"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Comment = null,
    /// <value>Total number of pages in the envelope</value>
    [property:
        JsonPropertyName("pages"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Pages = null,
    /// <value>Flow type of the envelope (REQUEST_SIGNATURE is a request for signature)</value>
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
    /// <value>Status of the envelope</value>
    [property:
        JsonPropertyName("status"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        EnvelopeStatus? Status = null,
    /// <value>Unix timestamp of the creation date</value>
    [property:
        JsonPropertyName("created_at"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? CreatedAt = null,
    /// <value>Unix timestamp of the last modification date</value>
    [property:
        JsonPropertyName("updated_at"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? UpdatedAt = null,
    /// <value>Unix timestamp of the expiration date</value>
    [property:
        JsonPropertyName("expires_at"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? ExpiresAt = null,
    /// <value>Number of recipients in the envelope</value>
    [property:
        JsonPropertyName("num_recipients"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? NumRecipients = null,
    /// <value>Whether the envelope can be duplicated</value>
    [property:
        JsonPropertyName("is_duplicable"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? IsDuplicable = null,
    [property:
        JsonPropertyName("signing_steps"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<SigningStep>? SigningSteps = null,
    [property:
        JsonPropertyName("documents"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<Document>? Documents = null,
    [property:
        JsonPropertyName("notification"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        EnvelopeNotification? Notification = null
);
