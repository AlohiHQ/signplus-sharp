using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AddEnvelopeAnnotationRequestSignature(
    [property:
        JsonPropertyName("id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Id = default
);
