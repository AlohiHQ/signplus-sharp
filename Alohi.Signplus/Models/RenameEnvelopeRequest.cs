using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record RenameEnvelopeRequest(
    /// <value>Name of the envelope</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Name = default
);
