using System.Text.Json.Serialization;
using Alohi.Signplus.Json;

namespace Alohi.Signplus.Models;

/// <summary>
/// Type of verification the recipient must complete before accessing the envelope.
///
/// - `PASSCODE`: requires a code to be entered.
/// - `SMS`: sends a code via SMS.
/// - `ID_VERIFICATION`: prompts the recipient to complete an automated ID and selfie check.
/// </summary>
public record RecipientVerificationType : ValueEnum<string>
{
    internal RecipientVerificationType(string value)
        : base(value) { }

    public RecipientVerificationType()
        : base("SMS") { }

    public static RecipientVerificationType Sms = new("SMS");
    public static RecipientVerificationType Passcode = new("PASSCODE");
    public static RecipientVerificationType IdVerification = new("ID_VERIFICATION");
}
