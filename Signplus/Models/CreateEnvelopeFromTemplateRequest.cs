using System.Text.Json.Serialization;

namespace Signplus.Models;

public record CreateEnvelopeFromTemplateRequest(
    /// <value>Name of the envelope</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Name = null,
    /// <value>Comment for the envelope</value>
    [property:
        JsonPropertyName("comment"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Comment = null,
    /// <value>Whether the envelope is created in sandbox mode</value>
    [property:
        JsonPropertyName("sandbox"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Sandbox = null
);
