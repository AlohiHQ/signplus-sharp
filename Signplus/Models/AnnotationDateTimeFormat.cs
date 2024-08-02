using System.Text.Json.Serialization;
using Signplus.Json;

namespace Signplus.Models;

/// <summary>Format of the date time (DMY_NUMERIC_SLASH is day/month/year with slashes, MDY_NUMERIC_SLASH is month/day/year with slashes, YMD_NUMERIC_SLASH is year/month/day with slashes, DMY_NUMERIC_DASH_SHORT is day/month/year with dashes, DMY_NUMERIC_DASH is day/month/year with dashes, YMD_NUMERIC_DASH is year/month/day with dashes, MDY_TEXT_DASH_SHORT is month/day/year with dashes, MDY_TEXT_SPACE_SHORT is month/day/year with spaces, MDY_TEXT_SPACE is month/day/year with spaces)</summary>
public record AnnotationDateTimeFormat : ValueEnum<string>
{
    internal AnnotationDateTimeFormat(string value)
        : base(value) { }

    public AnnotationDateTimeFormat()
        : base("DMY_NUMERIC_SLASH") { }

    public static AnnotationDateTimeFormat DmyNumericSlash = new("DMY_NUMERIC_SLASH");
    public static AnnotationDateTimeFormat MdyNumericSlash = new("MDY_NUMERIC_SLASH");
    public static AnnotationDateTimeFormat YmdNumericSlash = new("YMD_NUMERIC_SLASH");
    public static AnnotationDateTimeFormat DmyNumericDashShort = new("DMY_NUMERIC_DASH_SHORT");
    public static AnnotationDateTimeFormat DmyNumericDash = new("DMY_NUMERIC_DASH");
    public static AnnotationDateTimeFormat YmdNumericDash = new("YMD_NUMERIC_DASH");
    public static AnnotationDateTimeFormat MdyTextDashShort = new("MDY_TEXT_DASH_SHORT");
    public static AnnotationDateTimeFormat MdyTextSpaceShort = new("MDY_TEXT_SPACE_SHORT");
    public static AnnotationDateTimeFormat MdyTextSpace = new("MDY_TEXT_SPACE");
}
