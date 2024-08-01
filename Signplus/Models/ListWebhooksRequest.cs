using System.Text.Json.Serialization;

namespace Signplus.Models;

public record ListWebhooksRequest(
    /// <value>ID of the webhook</value>
    [property:
        JsonPropertyName("webhook_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? WebhookId = null,
    /// <value>Event of the webhook</value>
    [property:
        JsonPropertyName("event"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        WebhookEvent? Event_ = null
);
