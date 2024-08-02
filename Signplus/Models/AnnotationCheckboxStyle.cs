using System.Text.Json.Serialization;
using Signplus.Json;

namespace Signplus.Models;

/// <summary>Style of the checkbox</summary>
public record AnnotationCheckboxStyle : ValueEnum<string>
{
    internal AnnotationCheckboxStyle(string value)
        : base(value) { }

    public AnnotationCheckboxStyle()
        : base("CIRCLE_CHECK") { }

    public static AnnotationCheckboxStyle CircleCheck = new("CIRCLE_CHECK");
    public static AnnotationCheckboxStyle CircleFull = new("CIRCLE_FULL");
    public static AnnotationCheckboxStyle SquareCheck = new("SQUARE_CHECK");
    public static AnnotationCheckboxStyle SquareFull = new("SQUARE_FULL");
    public static AnnotationCheckboxStyle CheckMark = new("CHECK_MARK");
    public static AnnotationCheckboxStyle TimesSquare = new("TIMES_SQUARE");
}
