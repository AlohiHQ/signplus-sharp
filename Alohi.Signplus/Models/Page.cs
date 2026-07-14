using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record Page(
    /// <value>Width of the page in pixels</value>
    [property:
        JsonPropertyName("width"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<long> Width = default,
    /// <value>Height of the page in pixels</value>
    [property:
        JsonPropertyName("height"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<long> Height = default
);
