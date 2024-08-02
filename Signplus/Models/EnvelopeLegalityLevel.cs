using System.Text.Json.Serialization;
using Signplus.Json;

namespace Signplus.Models;

/// <summary>Legal level of the envelope (SES is Simple Electronic Signature, QES_EIDAS is Qualified Electronic Signature, QES_ZERTES is Qualified Electronic Signature with Zertes)</summary>
public record EnvelopeLegalityLevel : ValueEnum<string>
{
    internal EnvelopeLegalityLevel(string value)
        : base(value) { }

    public EnvelopeLegalityLevel()
        : base("SES") { }

    public static EnvelopeLegalityLevel Ses = new("SES");
    public static EnvelopeLegalityLevel QesEidas = new("QES_EIDAS");
    public static EnvelopeLegalityLevel QesZertes = new("QES_ZERTES");
}
