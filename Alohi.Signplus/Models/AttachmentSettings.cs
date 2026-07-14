using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AttachmentSettings(
    /// <value>Whether the attachment is visible to the recipients</value>
    [property:
        JsonPropertyName("visible_to_recipients"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<bool> VisibleToRecipients = default
);
