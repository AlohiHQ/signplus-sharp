using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record Template(
    /// <value>Unique identifier of the template</value>
    [property:
        JsonPropertyName("id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Id = default,
    /// <value>Name of the template</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Name = default,
    /// <value>Comment for the template</value>
    [property:
        JsonPropertyName("comment"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Comment = default,
    /// <value>Total number of pages in the template</value>
    [property:
        JsonPropertyName("pages"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<long> Pages = default,
    /// <value>Legal level of the envelope (SES is Simple Electronic Signature, QES_EIDAS is Qualified Electronic Signature, QES_ZERTES is Qualified Electronic Signature with Zertes)</value>
    [property:
        JsonPropertyName("legality_level"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<EnvelopeLegalityLevel> LegalityLevel = default,
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
    /// <value>Expiration delay added to the current time when an envelope is created from this template</value>
    [property:
        JsonPropertyName("expiration_delay"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<long> ExpirationDelay = default,
    /// <value>Number of recipients in the envelope</value>
    [property:
        JsonPropertyName("num_recipients"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<long> NumRecipients = default,
    [property:
        JsonPropertyName("signing_steps"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<TemplateSigningStep>> SigningSteps = default,
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
    /// <value>List of dynamic fields</value>
    [property:
        JsonPropertyName("dynamic_fields"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<List<string>> DynamicFields = default,
    [property:
        JsonPropertyName("attachments"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<EnvelopeAttachments> Attachments = default
);
