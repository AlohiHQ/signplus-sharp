using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record SetTemplateAttachmentsSettingsRequest(
    [property:
        JsonPropertyName("settings"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<SetTemplateAttachmentsSettingsRequestSettings?> Settings = default
);
