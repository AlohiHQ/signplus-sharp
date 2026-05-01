using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record SetEnvelopeLegalityLevelRequest(
    [property:
        JsonPropertyName("legality_level"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> LegalityLevel = default
);
