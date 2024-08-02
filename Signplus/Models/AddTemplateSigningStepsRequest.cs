using System.Text.Json.Serialization;

namespace Signplus.Models;

public record AddTemplateSigningStepsRequest(
    /// <value>List of signing steps</value>
    [property:
        JsonPropertyName("signing_steps"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<TemplateSigningStep>? SigningSteps = null
);
