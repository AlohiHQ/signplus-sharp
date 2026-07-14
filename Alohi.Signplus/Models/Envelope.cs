using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record Envelope(
    /// <value>Unique identifier of the envelope</value>
    [property:
        JsonPropertyName("id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Id = default,
    /// <value>Name of the envelope</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Name = default,
    /// <value>Comment for the envelope</value>
    [property:
        JsonPropertyName("comment"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Comment = default,
    /// <value>Total number of pages in the envelope</value>
    [property:
        JsonPropertyName("pages"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<long> Pages = default,
    /// <value>Flow type of the envelope (REQUEST_SIGNATURE is a request for signature, SIGN_MYSELF is a self-signing flow)</value>
    [property:
        JsonPropertyName("flow_type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<EnvelopeFlowType> FlowType = default,
    /// <value>Legal level of the envelope (SES is Simple Electronic Signature, QES_EIDAS is Qualified Electronic Signature, QES_ZERTES is Qualified Electronic Signature with Zertes)</value>
    [property:
        JsonPropertyName("legality_level"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<EnvelopeLegalityLevel> LegalityLevel = default,
    /// <value>Status of the envelope</value>
    [property:
        JsonPropertyName("status"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<EnvelopeStatus> Status = default,
    /// <value>Unix timestamp of the creation date</value>
    [property:
        JsonPropertyName("created_at"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<long> CreatedAt = default,
    /// <value>Unix timestamp of the last modification date</value>
    [property:
        JsonPropertyName("updated_at"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<long> UpdatedAt = default,
    /// <value>Unix timestamp of the expiration date</value>
    [property:
        JsonPropertyName("expires_at"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<long> ExpiresAt = default,
    /// <value>Number of recipients in the envelope</value>
    [property:
        JsonPropertyName("num_recipients"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<long> NumRecipients = default,
    /// <value>Whether the envelope can be duplicated</value>
    [property:
        JsonPropertyName("is_duplicable"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<bool> IsDuplicable = default,
    [property:
        JsonPropertyName("signing_steps"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<SigningStep>> SigningSteps = default,
    [property:
        JsonPropertyName("documents"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<Document>> Documents = default,
    [property:
        JsonPropertyName("notification"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<EnvelopeNotification> Notification = default,
    [property:
        JsonPropertyName("attachments"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<EnvelopeAttachments> Attachments = default
);
