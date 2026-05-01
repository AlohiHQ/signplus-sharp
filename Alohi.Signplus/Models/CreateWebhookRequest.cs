using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record CreateWebhookRequest(
    [property:
        JsonPropertyName("event"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Event_ = default,
    [property:
        JsonPropertyName("target"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Target = default
);
