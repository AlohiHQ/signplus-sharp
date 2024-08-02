using System.Text.Json.Serialization;
using Signplus.Json;

namespace Signplus.Models;

/// <summary>Role of the recipient (SIGNER signs the document, RECEIVES_COPY receives a copy of the document, IN_PERSON_SIGNER signs the document in person, SENDER sends the document)</summary>
public record TemplateRecipientRole : ValueEnum<string>
{
    internal TemplateRecipientRole(string value)
        : base(value) { }

    public TemplateRecipientRole()
        : base("SIGNER") { }

    public static TemplateRecipientRole Signer = new("SIGNER");
    public static TemplateRecipientRole ReceivesCopy = new("RECEIVES_COPY");
    public static TemplateRecipientRole InPersonSigner = new("IN_PERSON_SIGNER");
}
