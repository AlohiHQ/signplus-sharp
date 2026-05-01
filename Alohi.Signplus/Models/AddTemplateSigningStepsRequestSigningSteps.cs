using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AddTemplateSigningStepsRequestSigningSteps(
    [property:
        JsonPropertyName("recipients"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<SigningStepsRecipients2>?> Recipients = default
);
