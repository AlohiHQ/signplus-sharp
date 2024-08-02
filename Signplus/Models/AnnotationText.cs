using System.Text.Json.Serialization;

namespace Signplus.Models;

/// <summary>Text annotation (null if annotation is not a text)</summary>
public record AnnotationText(
    /// <value>Font size of the text in pt</value>
    [property:
        JsonPropertyName("size"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? Size = null,
    /// <value>Text color in 32bit representation</value>
    [property:
        JsonPropertyName("color"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? Color = null,
    /// <value>Text content of the annotation</value>
    [property:
        JsonPropertyName("value"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Value = null,
    /// <value>Tooltip of the annotation</value>
    [property:
        JsonPropertyName("tooltip"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Tooltip = null,
    /// <value>Name of the dynamic field</value>
    [property:
        JsonPropertyName("dynamic_field_name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? DynamicFieldName = null,
    [property:
        JsonPropertyName("font"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        AnnotationFont? Font = null
);
