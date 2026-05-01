using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record RenameTemplateRequest(
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Name = default
);
