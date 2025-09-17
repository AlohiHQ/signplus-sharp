using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AttachmentPlaceholdersPerRecipient(
    /// <value>ID of the recipient</value>
    [property:
        JsonPropertyName("recipient_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? RecipientId = null,
    /// <value>Name of the recipient</value>
    [property:
        JsonPropertyName("recipient_name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? RecipientName = null,
    [property:
        JsonPropertyName("placeholders"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<AttachmentPlaceholder>? Placeholders = null
);
