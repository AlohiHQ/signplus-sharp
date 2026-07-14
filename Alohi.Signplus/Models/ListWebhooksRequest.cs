using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record ListWebhooksRequest(
    /// <value>ID of the webhook</value>
    [property:
        JsonPropertyName("webhook_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> WebhookId = default,
    /// <value>Event of the webhook</value>
    [property:
        JsonPropertyName("event"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<WebhookEvent> Event_ = default
);
