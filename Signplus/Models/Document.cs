using System.Text.Json.Serialization;

namespace Signplus.Models;

public record Document(
    /// <value>Unique identifier of the document</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>Name of the document</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Name = null,
    /// <value>Filename of the document</value>
    [property:
        JsonPropertyName("filename"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Filename = null,
    /// <value>Number of pages in the document</value>
    [property:
        JsonPropertyName("page_count"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? PageCount = null,
    /// <value>List of pages in the document</value>
    [property:
        JsonPropertyName("pages"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<Page>? Pages = null
);
