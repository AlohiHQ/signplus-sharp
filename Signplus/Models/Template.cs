using System.Text.Json.Serialization;

namespace Signplus.Models;

public record Template(
    /// <value>Unique identifier of the template</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>Name of the template</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Name = null,
    /// <value>Comment for the template</value>
    [property:
        JsonPropertyName("comment"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Comment = null,
    /// <value>Total number of pages in the template</value>
    [property:
        JsonPropertyName("pages"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Pages = null,
    /// <value>Legal level of the envelope (SES is Simple Electronic Signature, QES_EIDAS is Qualified Electronic Signature, QES_ZERTES is Qualified Electronic Signature with Zertes)</value>
    [property:
        JsonPropertyName("legality_level"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        EnvelopeLegalityLevel? LegalityLevel = null,
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
    /// <value>Expiration delay added to the current time when an envelope is created from this template</value>
    [property:
        JsonPropertyName("expiration_delay"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? ExpirationDelay = null,
    /// <value>Number of recipients in the envelope</value>
    [property:
        JsonPropertyName("num_recipients"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? NumRecipients = null,
    [property:
        JsonPropertyName("signing_steps"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<TemplateSigningStep>? SigningSteps = null,
    [property:
        JsonPropertyName("documents"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<Document>? Documents = null,
    [property:
        JsonPropertyName("notification"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        EnvelopeNotification? Notification = null,
    /// <value>List of dynamic fields</value>
    [property:
        JsonPropertyName("dynamic_fields"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<string>? DynamicFields = null
);
