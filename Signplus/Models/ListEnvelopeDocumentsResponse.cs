using System.Text.Json.Serialization;

namespace Signplus.Models;

public record ListEnvelopeDocumentsResponse(
    [property:
        JsonPropertyName("documents"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<Document>? Documents = null
);
