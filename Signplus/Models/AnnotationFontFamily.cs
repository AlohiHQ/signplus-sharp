using System.Text.Json.Serialization;
using Signplus.Json;

namespace Signplus.Models;

/// <summary>Font family of the text</summary>
public record AnnotationFontFamily : ValueEnum<string>
{
    internal AnnotationFontFamily(string value)
        : base(value) { }

    public AnnotationFontFamily()
        : base("UNKNOWN") { }

    public static AnnotationFontFamily Unknown = new("UNKNOWN");
    public static AnnotationFontFamily Serif = new("SERIF");
    public static AnnotationFontFamily Sans = new("SANS");
    public static AnnotationFontFamily Mono = new("MONO");
}
