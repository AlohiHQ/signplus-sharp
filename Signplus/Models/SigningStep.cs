using System.Text.Json.Serialization;

namespace Signplus.Models;

public record SigningStep(
    /// <value>List of recipients</value>
    [property:
        JsonPropertyName("recipients"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<Recipient>? Recipients = null
);
