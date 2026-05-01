using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record CreateTemplateRequest(
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Name = default
);
