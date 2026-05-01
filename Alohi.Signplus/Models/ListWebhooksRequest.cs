using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record ListWebhooksRequest(
    [property:
        JsonPropertyName("webhook_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> WebhookId = default,
    [property:
        JsonPropertyName("event"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Event_ = default
);
