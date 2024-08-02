using System.Text.Json.Serialization;

namespace Signplus.Models;

public record SetTemplateCommentRequest(
    /// <value>Comment for the template</value>
    [property:
        JsonPropertyName("comment"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Comment = null
);
