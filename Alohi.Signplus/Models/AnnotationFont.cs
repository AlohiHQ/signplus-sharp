using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AnnotationFont(
    /// <value>Font family of the text</value>
    [property:
        JsonPropertyName("family"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<AnnotationFontFamily> Family = default,
    /// <value>Whether the text is italic</value>
    [property:
        JsonPropertyName("italic"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<bool> Italic = default,
    /// <value>Whether the text is bold</value>
    [property:
        JsonPropertyName("bold"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<bool> Bold = default
);
