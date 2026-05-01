using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record SetEnvelopeCommentRequest(
    [property:
        JsonPropertyName("comment"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Comment = default
);
