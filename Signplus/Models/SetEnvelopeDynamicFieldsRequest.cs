using System.Text.Json.Serialization;

namespace Signplus.Models;

public record SetEnvelopeDynamicFieldsRequest(
    /// <value>List of dynamic fields</value>
    [property:
        JsonPropertyName("dynamic_fields"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<DynamicField>? DynamicFields = null
);
