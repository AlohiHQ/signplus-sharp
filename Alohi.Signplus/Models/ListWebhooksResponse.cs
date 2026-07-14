using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record ListWebhooksResponse(
    [property:
        JsonPropertyName("webhooks"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<Webhook>> Webhooks = default
);
