using System.Text.Json.Serialization;

namespace Signplus.Models;

public record TemplateRecipient(
    /// <value>Unique identifier of the recipient</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>Unique identifier of the user associated with the recipient</value>
    [property:
        JsonPropertyName("uid"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Uid = null,
    /// <value>Name of the recipient</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Name = null,
    /// <value>Email of the recipient</value>
    [property:
        JsonPropertyName("email"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Email = null,
    /// <value>Role of the recipient (SIGNER signs the document, RECEIVES_COPY receives a copy of the document, IN_PERSON_SIGNER signs the document in person, SENDER sends the document)</value>
    [property:
        JsonPropertyName("role"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        TemplateRecipientRole? Role = null
);
