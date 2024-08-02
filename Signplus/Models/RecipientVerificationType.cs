using System.Text.Json.Serialization;
using Signplus.Json;

namespace Signplus.Models;

/// <summary>Type of signature verification (SMS sends a code via SMS, PASSCODE requires a code to be entered)</summary>
public record RecipientVerificationType : ValueEnum<string>
{
    internal RecipientVerificationType(string value)
        : base(value) { }

    public RecipientVerificationType()
        : base("SMS") { }

    public static RecipientVerificationType Sms = new("SMS");
    public static RecipientVerificationType Passcode = new("PASSCODE");
}
