using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AttachmentPlaceholder(
    /// <value>ID of the recipient</value>
    [property:
        JsonPropertyName("recipient_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> RecipientId = default,
    /// <value>ID of the attachment placeholder</value>
    [property:
        JsonPropertyName("id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Id = default,
    /// <value>Name of the attachment placeholder</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Name = default,
    /// <value>Hint of the attachment placeholder</value>
    [property:
        JsonPropertyName("hint"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Hint = default,
    /// <value>Whether the attachment placeholder is required</value>
    [property:
        JsonPropertyName("required"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<bool> Required = default,
    /// <value>Whether the attachment placeholder can have multiple files</value>
    [property:
        JsonPropertyName("multiple"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<bool> Multiple = default,
    [property:
        JsonPropertyName("files"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<AttachmentPlaceholderFile>> Files = default
);
