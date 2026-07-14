using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public class CreateEnvelopeRequest
{
    /// <value>Name of the envelope</value>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <value>Legal level of the envelope (SES is Simple Electronic Signature, QES_EIDAS is Qualified Electronic Signature, QES_ZERTES is Qualified Electronic Signature with Zertes)</value>
    [JsonPropertyName("legality_level")]
    public EnvelopeLegalityLevel LegalityLevel { get; init; }

    /// <value>Unix timestamp of the expiration date</value>
    [
        JsonPropertyName("expires_at"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
    public Optional<long> ExpiresAt { get; init; }

    /// <value>Comment for the envelope</value>
    [JsonPropertyName("comment"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> Comment { get; init; }

    /// <value>Whether the envelope is created in sandbox mode</value>
    [JsonPropertyName("sandbox"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<bool> Sandbox { get; init; }

    // Constructor with defaults applied
    public CreateEnvelopeRequest(
        string name,
        EnvelopeLegalityLevel legality_level,
        Optional<long> expires_at = default,
        Optional<string> comment = default,
        Optional<bool> sandbox = default
    )
    {
        Name = name;
        LegalityLevel = legality_level;
        ExpiresAt = expires_at;
        Comment = comment;
        Sandbox = sandbox.IsProvided ? sandbox : Optional<bool>.Of(false);
    }

    public override string ToString()
    {
        return $"{nameof(CreateEnvelopeRequest)} {{Name = {Name}, LegalityLevel = {LegalityLevel}, ExpiresAt = {ExpiresAt}, Comment = {Comment}, Sandbox = {Sandbox}}}";
    }
}
