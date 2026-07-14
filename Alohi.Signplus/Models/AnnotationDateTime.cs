using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

/// <summary>Date annotation (null if annotation is not a date)</summary>
public record AnnotationDateTime(
    /// <value>Font size of the text in pt</value>
    [property:
        JsonPropertyName("size"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<double> Size = default,
    [property:
        JsonPropertyName("font"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<AnnotationFont> Font = default,
    /// <value>Color of the text in hex format</value>
    [property:
        JsonPropertyName("color"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Color = default,
    /// <value>Whether the date should be automatically filled</value>
    [property:
        JsonPropertyName("auto_fill"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<bool> AutoFill = default,
    /// <value>Timezone of the date</value>
    [property:
        JsonPropertyName("timezone"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Timezone = default,
    /// <value>Unix timestamp of the date</value>
    [property:
        JsonPropertyName("timestamp"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<long> Timestamp = default,
    /// <value>Format of the date time (DMY_NUMERIC_SLASH is day/month/year with slashes, MDY_NUMERIC_SLASH is month/day/year with slashes, YMD_NUMERIC_SLASH is year/month/day with slashes, DMY_NUMERIC_DASH_SHORT is day/month/year with dashes, DMY_NUMERIC_DASH is day/month/year with dashes, YMD_NUMERIC_DASH is year/month/day with dashes, MDY_TEXT_DASH_SHORT is month/day/year with dashes, MDY_TEXT_SPACE_SHORT is month/day/year with spaces, MDY_TEXT_SPACE is month/day/year with spaces)</value>
    [property:
        JsonPropertyName("format"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<AnnotationDateTimeFormat> Format = default
);
