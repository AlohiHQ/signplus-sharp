using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

/// <summary>Text annotation (null if annotation is not a text)</summary>
public record AnnotationText(
    /// <value>Font size of the text in pt</value>
    [property:
        JsonPropertyName("size"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<double> Size = default,
    /// <value>Text color in 32bit representation</value>
    [property:
        JsonPropertyName("color"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<double> Color = default,
    /// <value>Text content of the annotation</value>
    [property:
        JsonPropertyName("value"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Value = default,
    /// <value>Tooltip of the annotation</value>
    [property:
        JsonPropertyName("tooltip"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Tooltip = default,
    /// <value>Name of the dynamic field</value>
    [property:
        JsonPropertyName("dynamic_field_name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> DynamicFieldName = default,
    [property:
        JsonPropertyName("font"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<AnnotationFont> Font = default
);
