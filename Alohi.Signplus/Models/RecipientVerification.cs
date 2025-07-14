using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record RecipientVerification(
    /// <value>
    /// Type of verification the recipient must complete before accessing the envelope.
    ///
    /// - `PASSCODE`: requires a code to be entered.
    /// - `SMS`: sends a code via SMS.
    /// - `ID_VERIFICATION`: prompts the recipient to complete an automated ID and selfie check.
    /// </value>
    [property:
        JsonPropertyName("type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        RecipientVerificationType? Type_ = null,
    /// <value>
    /// Required for `PASSCODE` and `SMS` verification.
    ///
    /// - `PASSCODE`: code required by the recipient to sign the document.
    /// - `SMS`: recipient's phone number.
    /// - `ID_VERIFICATION`: leave empty.
    /// </value>
    [property:
        JsonPropertyName("value"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Value = null
);
