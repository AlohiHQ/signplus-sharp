using System.Text.Json.Serialization;

namespace Signplus.Models;

public record SetEnvelopeCommentRequest(
    /// <value>Comment for the envelope</value>
    [property:
        JsonPropertyName("comment"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Comment = null
);