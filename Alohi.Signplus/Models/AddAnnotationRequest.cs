using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AddAnnotationRequest(
    /// <value>ID of the document</value>
    [property: JsonPropertyName("document_id")] string DocumentId,
    /// <value>Page number where the annotation is placed</value>
    [property: JsonPropertyName("page")] long Page,
    /// <value>X coordinate of the annotation (in % of the page width from 0 to 100) from the top left corner</value>
    [property: JsonPropertyName("x")] double X,
    /// <value>Y coordinate of the annotation (in % of the page height from 0 to 100) from the top left corner</value>
    [property: JsonPropertyName("y")] double Y,
    /// <value>Width of the annotation (in % of the page width from 0 to 100)</value>
    [property: JsonPropertyName("width")] double Width,
    /// <value>Height of the annotation (in % of the page height from 0 to 100)</value>
    [property: JsonPropertyName("height")] double Height,
    /// <value>Type of the annotation</value>
    [property: JsonPropertyName("type")] AnnotationType Type_,
    /// <value>ID of the recipient</value>
    [property:
        JsonPropertyName("recipient_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> RecipientId = default,
    [property:
        JsonPropertyName("required"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<bool> Required = default,
    /// <value>Signature annotation (null if annotation is not a signature)</value>
    [property:
        JsonPropertyName("signature"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<AnnotationSignature> Signature = default,
    /// <value>Initials annotation (null if annotation is not initials)</value>
    [property:
        JsonPropertyName("initials"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<AnnotationInitials> Initials = default,
    /// <value>Text annotation (null if annotation is not a text)</value>
    [property:
        JsonPropertyName("text"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<AnnotationText> Text = default,
    /// <value>Date annotation (null if annotation is not a date)</value>
    [property:
        JsonPropertyName("datetime"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<AnnotationDateTime> Datetime = default,
    /// <value>Checkbox annotation (null if annotation is not a checkbox)</value>
    [property:
        JsonPropertyName("checkbox"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<AnnotationCheckbox> Checkbox = default
);
