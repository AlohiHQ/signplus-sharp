using System.Text.Json.Serialization;
using Alohi.Signplus.Json;

namespace Alohi.Signplus.Models;

/// <summary>Flow type of the envelope (REQUEST_SIGNATURE is a request for signature, SIGN_MYSELF is a self-signing flow)</summary>
public record EnvelopeFlowType : ValueEnum<string>
{
    internal EnvelopeFlowType(string value)
        : base(value) { }

    public EnvelopeFlowType()
        : base("REQUEST_SIGNATURE") { }

    public static EnvelopeFlowType RequestSignature = new("REQUEST_SIGNATURE");
    public static EnvelopeFlowType SignMyself = new("SIGN_MYSELF");
}
