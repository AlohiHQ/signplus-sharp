using System.Text.Json.Serialization;

namespace Signplus.Models;

public record RenameEnvelopeRequest(
    /// <value>Name of the envelope</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Name = null
);
