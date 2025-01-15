using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record TemplateSigningStep(
    /// <value>List of recipients</value>
    [property:
        JsonPropertyName("recipients"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<TemplateRecipient>? Recipients = null
);
