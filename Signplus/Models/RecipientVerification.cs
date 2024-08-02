using System.Text.Json.Serialization;

namespace Signplus.Models;

public record RecipientVerification(
    /// <value>Type of signature verification (SMS sends a code via SMS, PASSCODE requires a code to be entered)</value>
    [property:
        JsonPropertyName("type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        RecipientVerificationType? Type_ = null,
    [property:
        JsonPropertyName("value"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Value = null
);
