using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AddEnvelopeDocumentRequest(
    /// <value>File to upload in binary format</value>
    [property:
        JsonPropertyName("file"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<byte[]> File = default
);
