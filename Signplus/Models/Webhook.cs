using System.Text.Json.Serialization;

namespace Signplus.Models;

public record Webhook(
    /// <value>Unique identifier of the webhook</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>Event of the webhook</value>
    [property:
        JsonPropertyName("event"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        WebhookEvent? Event_ = null,
    /// <value>Target URL of the webhook</value>
    [property:
        JsonPropertyName("target"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Target = null
);
