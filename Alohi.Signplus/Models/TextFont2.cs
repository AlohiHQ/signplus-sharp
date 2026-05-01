using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record TextFont2(
    [property:
        JsonPropertyName("family"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Family = default,
    [property:
        JsonPropertyName("italic"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<bool?> Italic = default,
    [property:
        JsonPropertyName("bold"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<bool?> Bold = default
);
