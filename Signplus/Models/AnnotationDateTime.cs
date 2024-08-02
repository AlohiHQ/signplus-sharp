using System.Text.Json.Serialization;

namespace Signplus.Models;

/// <summary>Date annotation (null if annotation is not a date)</summary>
public record AnnotationDateTime(
    /// <value>Font size of the text in pt</value>
    [property:
        JsonPropertyName("size"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? Size = null,
    [property:
        JsonPropertyName("font"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        AnnotationFont? Font = null,
    /// <value>Color of the text in hex format</value>
    [property:
        JsonPropertyName("color"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Color = null,
    /// <value>Whether the date should be automatically filled</value>
    [property:
        JsonPropertyName("auto_fill"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? AutoFill = null,
    /// <value>Timezone of the date</value>
    [property:
        JsonPropertyName("timezone"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Timezone = null,
    /// <value>Unix timestamp of the date</value>
    [property:
        JsonPropertyName("timestamp"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Timestamp = null,
    /// <value>Format of the date time (DMY_NUMERIC_SLASH is day/month/year with slashes, MDY_NUMERIC_SLASH is month/day/year with slashes, YMD_NUMERIC_SLASH is year/month/day with slashes, DMY_NUMERIC_DASH_SHORT is day/month/year with dashes, DMY_NUMERIC_DASH is day/month/year with dashes, YMD_NUMERIC_DASH is year/month/day with dashes, MDY_TEXT_DASH_SHORT is month/day/year with dashes, MDY_TEXT_SPACE_SHORT is month/day/year with spaces, MDY_TEXT_SPACE is month/day/year with spaces)</value>
    [property:
        JsonPropertyName("format"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        AnnotationDateTimeFormat? Format = null
);
