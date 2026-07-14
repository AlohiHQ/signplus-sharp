using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record Webhook(
    /// <value>Unique identifier of the webhook</value>
    [property:
        JsonPropertyName("id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Id = default,
    /// <value>Event of the webhook</value>
    [property:
        JsonPropertyName("event"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<WebhookEvent> Event_ = default,
    /// <value>Target URL of the webhook</value>
    [property:
        JsonPropertyName("target"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Target = default
);
