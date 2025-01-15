using System.Text.Json.Serialization;
using Alohi.Signplus.Json;

namespace Alohi.Signplus.Models;

/// <summary>Event of the webhook</summary>
public record WebhookEvent : ValueEnum<string>
{
    internal WebhookEvent(string value)
        : base(value) { }

    public WebhookEvent()
        : base("ENVELOPE_EXPIRED") { }

    public static WebhookEvent EnvelopeExpired = new("ENVELOPE_EXPIRED");
    public static WebhookEvent EnvelopeDeclined = new("ENVELOPE_DECLINED");
    public static WebhookEvent EnvelopeVoided = new("ENVELOPE_VOIDED");
    public static WebhookEvent EnvelopeCompleted = new("ENVELOPE_COMPLETED");
}
