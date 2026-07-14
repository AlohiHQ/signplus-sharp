using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record RenameTemplateRequest(
    /// <value>Name of the template</value>
    [property: JsonPropertyName("name")] string Name
);
