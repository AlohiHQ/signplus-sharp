using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record TemplateRecipient(
    /// <value>Unique identifier of the recipient</value>
    [property:
        JsonPropertyName("id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Id = default,
    /// <value>Unique identifier of the user associated with the recipient</value>
    [property:
        JsonPropertyName("uid"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Uid = default,
    /// <value>Name of the recipient</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Name = default,
    /// <value>Email of the recipient</value>
    [property:
        JsonPropertyName("email"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Email = default,
    /// <value>Role of the recipient (SIGNER signs the document, RECEIVES_COPY receives a copy of the document, IN_PERSON_SIGNER signs the document in person, SENDER sends the document)</value>
    [property:
        JsonPropertyName("role"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<TemplateRecipientRole> Role = default
);
