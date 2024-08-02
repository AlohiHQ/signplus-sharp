using System.Text.Json.Serialization;

namespace Signplus.Models;

public record Annotation(
    /// <value>Unique identifier of the annotation</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>ID of the recipient</value>
    [property:
        JsonPropertyName("recipient_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? RecipientId = null,
    /// <value>ID of the document</value>
    [property:
        JsonPropertyName("document_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? DocumentId = null,
    /// <value>Page number where the annotation is placed</value>
    [property:
        JsonPropertyName("page"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Page = null,
    /// <value>X coordinate of the annotation (in % of the page width from 0 to 100) from the top left corner</value>
    [property: JsonPropertyName("x"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        double? X = null,
    /// <value>Y coordinate of the annotation (in % of the page height from 0 to 100) from the top left corner</value>
    [property: JsonPropertyName("y"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        double? Y = null,
    /// <value>Width of the annotation (in % of the page width from 0 to 100)</value>
    [property:
        JsonPropertyName("width"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? Width = null,
    /// <value>Height of the annotation (in % of the page height from 0 to 100)</value>
    [property:
        JsonPropertyName("height"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? Height = null,
    /// <value>Whether the annotation is required</value>
    [property:
        JsonPropertyName("required"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Required = null,
    /// <value>Type of the annotation</value>
    [property:
        JsonPropertyName("type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        AnnotationType? Type_ = null,
    /// <value>Signature annotation (null if annotation is not a signature)</value>
    [property:
        JsonPropertyName("signature"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        AnnotationSignature? Signature = null,
    /// <value>Initials annotation (null if annotation is not initials)</value>
    [property:
        JsonPropertyName("initials"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        AnnotationInitials? Initials = null,
    /// <value>Text annotation (null if annotation is not a text)</value>
    [property:
        JsonPropertyName("text"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        AnnotationText? Text = null,
    /// <value>Date annotation (null if annotation is not a date)</value>
    [property:
        JsonPropertyName("datetime"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        AnnotationDateTime? Datetime = null,
    /// <value>Checkbox annotation (null if annotation is not a checkbox)</value>
    [property:
        JsonPropertyName("checkbox"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        AnnotationCheckbox? Checkbox = null
);
