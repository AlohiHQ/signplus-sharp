using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record RenameEnvelopeRequest(
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Name = default
);
