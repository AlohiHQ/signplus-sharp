using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record SigningStep(
    /// <value>List of recipients</value>
    [property:
        JsonPropertyName("recipients"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<List<Recipient>> Recipients = default
);
