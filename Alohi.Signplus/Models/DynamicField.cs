using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record DynamicField(
    /// <value>Name of the dynamic field</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Name = default,
    /// <value>Value of the dynamic field</value>
    [property:
        JsonPropertyName("value"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Value = default
);
