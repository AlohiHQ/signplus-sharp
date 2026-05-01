using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record SetEnvelopeAttachmentsPlaceholdersRequest(
    [property:
        JsonPropertyName("placeholders"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<SetEnvelopeAttachmentsPlaceholdersRequestPlaceholders>?> Placeholders =
        default
);
