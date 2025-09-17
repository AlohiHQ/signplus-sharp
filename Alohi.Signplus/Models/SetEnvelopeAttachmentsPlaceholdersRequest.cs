using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record SetEnvelopeAttachmentsPlaceholdersRequest(
    [property: JsonPropertyName("placeholders")] List<AttachmentPlaceholderRequest> Placeholders
);
