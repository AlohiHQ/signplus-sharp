using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record SetTemplateAttachmentsPlaceholdersRequest(
    [property:
        JsonPropertyName("placeholders"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<SetTemplateAttachmentsPlaceholdersRequestPlaceholders>?> Placeholders =
        default
);
