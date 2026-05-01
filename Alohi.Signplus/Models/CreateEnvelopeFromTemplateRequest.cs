using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record CreateEnvelopeFromTemplateRequest(
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Name = default,
    [property:
        JsonPropertyName("comment"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Comment = default,
    [property:
        JsonPropertyName("sandbox"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<bool?> Sandbox = default
);
