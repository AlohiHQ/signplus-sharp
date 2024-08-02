using System.Text.Json.Serialization;

namespace Signplus.Models;

public record ListTemplatesRequest(
    /// <value>Name of the template</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Name = null,
    /// <value>List of tag templates</value>
    [property:
        JsonPropertyName("tags"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<string>? Tags = null,
    /// <value>List of templates IDs</value>
    [property:
        JsonPropertyName("ids"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<string>? Ids = null,
    [property:
        JsonPropertyName("first"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? First = null,
    [property:
        JsonPropertyName("last"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? Last = null,
    [property:
        JsonPropertyName("after"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? After = null,
    [property:
        JsonPropertyName("before"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Before = null,
    /// <value>Field to order templates by</value>
    [property:
        JsonPropertyName("order_field"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        TemplateOrderField? OrderField = null,
    /// <value>Whether to order templates in ascending order</value>
    [property:
        JsonPropertyName("ascending"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Ascending = null
);
