using System.Text.Json.Serialization;

namespace Signplus.Models;

/// <summary>Initials annotation (null if annotation is not initials)</summary>
public record AnnotationInitials(
    /// <value>Unique identifier of the annotation initials</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null
);
