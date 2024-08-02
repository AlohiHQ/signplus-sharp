using System.Text.Json.Serialization;

namespace Signplus.Models;

public record ListEnvelopeDocumentAnnotationsResponse(
    [property:
        JsonPropertyName("annotations"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<Annotation>? Annotations = null
);
