using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record CreateTemplateRequest([property: JsonPropertyName("name")] string Name);
