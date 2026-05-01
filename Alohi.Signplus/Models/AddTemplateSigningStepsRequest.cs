using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AddTemplateSigningStepsRequest(
    [property:
        JsonPropertyName("signing_steps"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<AddTemplateSigningStepsRequestSigningSteps>?> SigningSteps = default
);
