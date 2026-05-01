using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record SetTemplateCommentRequest(
    [property:
        JsonPropertyName("comment"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Comment = default
);
