using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record SetEnvelopeAttachmentsSettingsRequest(
    [property: JsonPropertyName("settings")] AttachmentSettings Settings
);
