using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AddEnvelopeSigningStepsRequest(
    [property:
        JsonPropertyName("signing_steps"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<AddEnvelopeSigningStepsRequestSigningSteps>?> SigningSteps = default
);
