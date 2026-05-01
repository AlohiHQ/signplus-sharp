using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AddTemplateDocumentRequest(
    [property:
        JsonPropertyName("file"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<byte[]?> File = default
);
