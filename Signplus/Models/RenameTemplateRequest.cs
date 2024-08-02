using System.Text.Json.Serialization;

namespace Signplus.Models;

public record RenameTemplateRequest(
    /// <value>Name of the template</value>
    [property: JsonPropertyName("name")]
        string Name
);
