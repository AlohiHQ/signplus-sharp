using System.Text.Json.Serialization;

namespace Signplus.Models;

public record AddEnvelopeDocumentRequest(
    /// <value>File to upload in binary format</value>
    [property:
        JsonPropertyName("file"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? File = null
);
