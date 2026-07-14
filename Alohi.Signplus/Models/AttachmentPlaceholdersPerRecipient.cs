using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AttachmentPlaceholdersPerRecipient(
    /// <value>ID of the recipient</value>
    [property:
        JsonPropertyName("recipient_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> RecipientId = default,
    /// <value>Name of the recipient</value>
    [property:
        JsonPropertyName("recipient_name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> RecipientName = default,
    [property:
        JsonPropertyName("placeholders"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<AttachmentPlaceholder>> Placeholders = default
);
