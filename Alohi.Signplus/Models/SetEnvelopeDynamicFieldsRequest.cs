using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record SetEnvelopeDynamicFieldsRequest(
    [property:
        JsonPropertyName("dynamic_fields"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<DynamicFields>?> DynamicFields = default
);
