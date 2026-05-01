using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record AddTemplateAnnotationRequest(
    [property:
        JsonPropertyName("document_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> DocumentId = default,
    [property:
        JsonPropertyName("page"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<double?> Page = default,
    [property:
        JsonPropertyName("x"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<double?> X = default,
    [property:
        JsonPropertyName("y"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<double?> Y = default,
    [property:
        JsonPropertyName("width"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<double?> Width = default,
    [property:
        JsonPropertyName("height"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<double?> Height = default,
    [property:
        JsonPropertyName("type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Type_ = default,
    [property:
        JsonPropertyName("recipient_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> RecipientId = default,
    [property:
        JsonPropertyName("required"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<bool?> Required = default,
    [property:
        JsonPropertyName("signature"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<AddTemplateAnnotationRequestSignature?> Signature = default,
    [property:
        JsonPropertyName("initials"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<AddTemplateAnnotationRequestInitials?> Initials = default,
    [property:
        JsonPropertyName("text"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<AddTemplateAnnotationRequestText?> Text = default,
    [property:
        JsonPropertyName("datetime"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<AddTemplateAnnotationRequestDatetime?> Datetime = default,
    [property:
        JsonPropertyName("checkbox"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<AddTemplateAnnotationRequestCheckbox?> Checkbox = default
);
