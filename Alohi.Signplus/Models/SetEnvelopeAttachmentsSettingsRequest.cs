using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record SetEnvelopeAttachmentsSettingsRequest(
    [property:
        JsonPropertyName("settings"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<SetEnvelopeAttachmentsSettingsRequestSettings?> Settings = default
);
