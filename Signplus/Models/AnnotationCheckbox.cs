using System.Text.Json.Serialization;

namespace Signplus.Models;

/// <summary>Checkbox annotation (null if annotation is not a checkbox)</summary>
public record AnnotationCheckbox(
    /// <value>Whether the checkbox is checked</value>
    [property:
        JsonPropertyName("checked"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Checked_ = null,
    /// <value>Style of the checkbox</value>
    [property:
        JsonPropertyName("style"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        AnnotationCheckboxStyle? Style = null
);
