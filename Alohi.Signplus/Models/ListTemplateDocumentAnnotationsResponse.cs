using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record ListTemplateDocumentAnnotationsResponse(
    [property:
        JsonPropertyName("annotations"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<Annotation>? Annotations = null
);
