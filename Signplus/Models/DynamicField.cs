using System.Text.Json.Serialization;

namespace Signplus.Models;

public record DynamicField(
    /// <value>Name of the dynamic field</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Name = null,
    /// <value>Value of the dynamic field</value>
    [property:
        JsonPropertyName("value"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Value = null
);
