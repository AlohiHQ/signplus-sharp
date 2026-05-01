using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AddTemplateAnnotationRequestInitials(
    [property:
        JsonPropertyName("id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Id = default
);
