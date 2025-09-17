using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AttachmentPlaceholderFile(
    /// <value>ID of the file</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>Name of the file</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Name = null,
    /// <value>Size of the file in bytes</value>
    [property:
        JsonPropertyName("size"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Size = null,
    /// <value>MIME type of the file</value>
    [property:
        JsonPropertyName("mimetype"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Mimetype = null
);
