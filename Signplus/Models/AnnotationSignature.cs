using System.Text.Json.Serialization;

namespace Signplus.Models;

/// <summary>Signature annotation (null if annotation is not a signature)</summary>
public record AnnotationSignature(
    /// <value>Unique identifier of the annotation signature</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null
);
