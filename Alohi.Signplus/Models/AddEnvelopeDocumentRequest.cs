using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AddEnvelopeDocumentRequest(
    [property:
        JsonPropertyName("file"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<byte[]?> File = default
);
