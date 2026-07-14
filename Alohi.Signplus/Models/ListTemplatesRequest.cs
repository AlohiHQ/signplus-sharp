using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record ListTemplatesRequest(
    /// <value>Name of the template</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Name = default,
    /// <value>List of tag templates</value>
    [property:
        JsonPropertyName("tags"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<List<string>> Tags = default,
    /// <value>List of templates IDs</value>
    [property:
        JsonPropertyName("ids"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<List<string>> Ids = default,
    [property:
        JsonPropertyName("first"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<long> First = default,
    [property:
        JsonPropertyName("last"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<long> Last = default,
    [property:
        JsonPropertyName("after"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string> After = default,
    [property:
        JsonPropertyName("before"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string> Before = default,
    /// <value>Field to order templates by</value>
    [property:
        JsonPropertyName("order_field"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<TemplateOrderField> OrderField = default,
    /// <value>Whether to order templates in ascending order</value>
    [property:
        JsonPropertyName("ascending"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<bool> Ascending = default
);
