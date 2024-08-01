using System.Text.Json.Serialization;
using Signplus.Json;

namespace Signplus.Models;

/// <summary>Role of the recipient (SIGNER signs the document, RECEIVES_COPY receives a copy of the document, IN_PERSON_SIGNER signs the document in person, SENDER sends the document)</summary>
public record RecipientRole : ValueEnum<string>
{
    internal RecipientRole(string value)
        : base(value) { }

    public RecipientRole()
        : base("SIGNER") { }

    public static RecipientRole Signer = new("SIGNER");
    public static RecipientRole ReceivesCopy = new("RECEIVES_COPY");
    public static RecipientRole InPersonSigner = new("IN_PERSON_SIGNER");
}
