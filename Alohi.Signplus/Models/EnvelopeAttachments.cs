using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record EnvelopeAttachments(
    [property:
        JsonPropertyName("settings"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<AttachmentSettings> Settings = default,
    [property:
        JsonPropertyName("recipients"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<AttachmentPlaceholdersPerRecipient>> Recipients = default
);
