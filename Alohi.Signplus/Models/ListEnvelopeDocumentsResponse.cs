using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record ListEnvelopeDocumentsResponse(
    [property:
        JsonPropertyName("documents"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<Document>> Documents = default
);
