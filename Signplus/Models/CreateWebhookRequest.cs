using System.Text.Json.Serialization;

namespace Signplus.Models;

public record CreateWebhookRequest(
    /// <value>Event of the webhook</value>
    [property: JsonPropertyName("event")]
        WebhookEvent Event_,
    /// <value>URL of the webhook target</value>
    [property: JsonPropertyName("target")]
        string Target
);
