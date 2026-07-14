using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record Annotation(
    /// <value>Unique identifier of the annotation</value>
    [property:
        JsonPropertyName("id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Id = default,
    /// <value>ID of the recipient</value>
    [property:
        JsonPropertyName("recipient_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> RecipientId = default,
    /// <value>ID of the document</value>
    [property:
        JsonPropertyName("document_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> DocumentId = default,
    /// <value>Page number where the annotation is placed</value>
    [property:
        JsonPropertyName("page"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<long> Page = default,
    /// <value>X coordinate of the annotation (in % of the page width from 0 to 100) from the top left corner</value>
    [property:
        JsonPropertyName("x"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<double> X = default,
    /// <value>Y coordinate of the annotation (in % of the page height from 0 to 100) from the top left corner</value>
    [property:
        JsonPropertyName("y"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<double> Y = default,
    /// <value>Width of the annotation (in % of the page width from 0 to 100)</value>
    [property:
        JsonPropertyName("width"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<double> Width = default,
    /// <value>Height of the annotation (in % of the page height from 0 to 100)</value>
    [property:
        JsonPropertyName("height"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<double> Height = default,
    /// <value>Whether the annotation is required</value>
    [property:
        JsonPropertyName("required"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<bool> Required = default,
    /// <value>Type of the annotation</value>
    [property:
        JsonPropertyName("type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<AnnotationType> Type_ = default,
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
