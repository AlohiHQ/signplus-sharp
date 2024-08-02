using System.Text.Json.Serialization;

namespace Signplus.Models;

public record ListWebhooksResponse(
    [property:
        JsonPropertyName("webhooks"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<Webhook>? Webhooks = null
);
