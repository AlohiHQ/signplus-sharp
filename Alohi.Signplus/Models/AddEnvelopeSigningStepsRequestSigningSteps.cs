using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AddEnvelopeSigningStepsRequestSigningSteps(
    [property:
        JsonPropertyName("recipients"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<SigningStepsRecipients1>?> Recipients = default
);
