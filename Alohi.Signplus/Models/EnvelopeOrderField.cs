using System.Text.Json.Serialization;
using Alohi.Signplus.Json;

namespace Alohi.Signplus.Models;

/// <summary>Field to order envelopes by</summary>
public record EnvelopeOrderField : ValueEnum<string>
{
    internal EnvelopeOrderField(string value)
        : base(value) { }

    public EnvelopeOrderField()
        : base("CREATION_DATE") { }

    public static EnvelopeOrderField CreationDate = new("CREATION_DATE");
    public static EnvelopeOrderField ModificationDate = new("MODIFICATION_DATE");
    public static EnvelopeOrderField Name = new("NAME");
    public static EnvelopeOrderField Status = new("STATUS");
    public static EnvelopeOrderField LastDocumentChange = new("LAST_DOCUMENT_CHANGE");
}
