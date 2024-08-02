using System.Text.Json.Serialization;
using Signplus.Json;

namespace Signplus.Models;

/// <summary>Status of the envelope</summary>
public record EnvelopeStatus : ValueEnum<string>
{
    internal EnvelopeStatus(string value)
        : base(value) { }

    public EnvelopeStatus()
        : base("DRAFT") { }

    public static EnvelopeStatus Draft = new("DRAFT");
    public static EnvelopeStatus InProgress = new("IN_PROGRESS");
    public static EnvelopeStatus Completed = new("COMPLETED");
    public static EnvelopeStatus Expired = new("EXPIRED");
    public static EnvelopeStatus Declined = new("DECLINED");
    public static EnvelopeStatus Voided = new("VOIDED");
    public static EnvelopeStatus Pending = new("PENDING");
}
