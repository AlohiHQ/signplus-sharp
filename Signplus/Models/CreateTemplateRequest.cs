using System.Text.Json.Serialization;

namespace Signplus.Models;

public record CreateTemplateRequest([property: JsonPropertyName("name")] string Name);
