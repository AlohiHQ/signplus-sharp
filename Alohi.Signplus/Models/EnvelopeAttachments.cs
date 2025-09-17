using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record EnvelopeAttachments(
    [property:
        JsonPropertyName("settings"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        AttachmentSettings? Settings = null,
    [property:
        JsonPropertyName("recipients"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<AttachmentPlaceholdersPerRecipient>? Recipients = null
);
