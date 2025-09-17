using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AttachmentPlaceholderRequest(
    /// <value>ID of the recipient</value>
    [property: JsonPropertyName("recipient_id")]
        string RecipientId,
    [property: JsonPropertyName("name")] string Name,
    /// <value>Whether the attachment placeholder is required</value>
    [property: JsonPropertyName("required")]
        bool Required,
    [property: JsonPropertyName("multiple")] bool Multiple,
    /// <value>ID of the attachment placeholder</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>Hint of the attachment placeholder</value>
    [property:
        JsonPropertyName("hint"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Hint = null
);
