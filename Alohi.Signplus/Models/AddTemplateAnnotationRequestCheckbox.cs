using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AddTemplateAnnotationRequestCheckbox(
    [property:
        JsonPropertyName("checked"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Checked_ = default,
    [property:
        JsonPropertyName("style"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Style = default
);
