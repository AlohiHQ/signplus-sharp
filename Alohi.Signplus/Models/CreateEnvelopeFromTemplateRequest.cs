using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public class CreateEnvelopeFromTemplateRequest
{
    /// <value>Name of the envelope</value>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <value>Comment for the envelope</value>
    [JsonPropertyName("comment"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<string> Comment { get; init; }

    /// <value>Whether the envelope is created in sandbox mode</value>
    [JsonPropertyName("sandbox"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public Optional<bool> Sandbox { get; init; }

    // Constructor with defaults applied
    public CreateEnvelopeFromTemplateRequest(
        string name,
        Optional<string> comment = default,
        Optional<bool> sandbox = default
    )
    {
        Name = name;
        Comment = comment;
        Sandbox = sandbox.IsProvided ? sandbox : Optional<bool>.Of(false);
    }

    public override string ToString()
    {
        return $"{nameof(CreateEnvelopeFromTemplateRequest)} {{Name = {Name}, Comment = {Comment}, Sandbox = {Sandbox}}}";
    }
}
