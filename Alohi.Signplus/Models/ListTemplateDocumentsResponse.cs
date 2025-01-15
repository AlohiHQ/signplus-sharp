using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record ListTemplateDocumentsResponse(
    [property:
        JsonPropertyName("documents"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<Document>? Documents = null
);
