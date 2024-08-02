using System.Text.Json.Serialization;

namespace Signplus.Models;

public record Recipient(
    /// <value>Name of the recipient</value>
    [property: JsonPropertyName("name")]
        string Name,
    /// <value>Email of the recipient</value>
    [property: JsonPropertyName("email")]
        string Email,
    /// <value>Role of the recipient (SIGNER signs the document, RECEIVES_COPY receives a copy of the document, IN_PERSON_SIGNER signs the document in person, SENDER sends the document)</value>
    [property: JsonPropertyName("role")]
        RecipientRole Role,
    /// <value>Unique identifier of the recipient</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>Unique identifier of the user associated with the recipient</value>
    [property:
        JsonPropertyName("uid"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Uid = null,
    [property:
        JsonPropertyName("verification"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        RecipientVerification? Verification = null
);
