using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

/// <summary>Checkbox annotation (null if annotation is not a checkbox)</summary>
public record AnnotationCheckbox(
    /// <value>Whether the checkbox is checked</value>
    [property:
        JsonPropertyName("checked"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<bool> Checked_ = default,
    /// <value>Style of the checkbox</value>
    [property:
        JsonPropertyName("style"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<AnnotationCheckboxStyle> Style = default
);
