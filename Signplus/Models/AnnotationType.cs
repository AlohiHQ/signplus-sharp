using System.Text.Json.Serialization;
using Signplus.Json;

namespace Signplus.Models;

/// <summary>Type of the annotation</summary>
public record AnnotationType : ValueEnum<string>
{
    internal AnnotationType(string value)
        : base(value) { }

    public AnnotationType()
        : base("TEXT") { }

    public static AnnotationType Text = new("TEXT");
    public static AnnotationType Signature = new("SIGNATURE");
    public static AnnotationType Initials = new("INITIALS");
    public static AnnotationType Checkbox = new("CHECKBOX");
    public static AnnotationType Date = new("DATE");
}
