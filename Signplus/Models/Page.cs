using System.Text.Json.Serialization;

namespace Signplus.Models;

public record Page(
    /// <value>Width of the page in pixels</value>
    [property:
        JsonPropertyName("width"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Width = null,
    /// <value>Height of the page in pixels</value>
    [property:
        JsonPropertyName("height"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Height = null
);
