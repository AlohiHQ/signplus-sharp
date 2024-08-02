using System.Text.Json.Serialization;

namespace Signplus.Models;

public record AnnotationFont(
    /// <value>Font family of the text</value>
    [property:
        JsonPropertyName("family"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        AnnotationFontFamily? Family = null,
    /// <value>Whether the text is italic</value>
    [property:
        JsonPropertyName("italic"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Italic = null,
    /// <value>Whether the text is bold</value>
    [property:
        JsonPropertyName("bold"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Bold = null
);
