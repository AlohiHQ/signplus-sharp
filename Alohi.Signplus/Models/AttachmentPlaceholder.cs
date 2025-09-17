using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AttachmentPlaceholder(
    /// <value>ID of the recipient</value>
    [property:
        JsonPropertyName("recipient_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? RecipientId = null,
    /// <value>ID of the attachment placeholder</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>Name of the attachment placeholder</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Name = null,
    /// <value>Hint of the attachment placeholder</value>
    [property:
        JsonPropertyName("hint"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Hint = null,
    /// <value>Whether the attachment placeholder is required</value>
    [property:
        JsonPropertyName("required"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Required = null,
    /// <value>Whether the attachment placeholder can have multiple files</value>
    [property:
        JsonPropertyName("multiple"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Multiple = null,
    [property:
        JsonPropertyName("files"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<AttachmentPlaceholderFile>? Files = null
);
