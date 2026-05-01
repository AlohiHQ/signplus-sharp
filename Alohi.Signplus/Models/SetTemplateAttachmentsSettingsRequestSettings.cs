using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record SetTemplateAttachmentsSettingsRequestSettings(
    [property:
        JsonPropertyName("visible_to_recipients"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> VisibleToRecipients = default
);
