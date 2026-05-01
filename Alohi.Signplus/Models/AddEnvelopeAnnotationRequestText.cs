using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AddEnvelopeAnnotationRequestText(
    [property:
        JsonPropertyName("size"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Size = default,
    [property:
        JsonPropertyName("color"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Color = default,
    [property:
        JsonPropertyName("value"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Value = default,
    [property:
        JsonPropertyName("tooltip"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Tooltip = default,
    [property:
        JsonPropertyName("dynamic_field_name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> DynamicFieldName = default,
    [property:
        JsonPropertyName("font"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<TextFont1?> Font = default
);
