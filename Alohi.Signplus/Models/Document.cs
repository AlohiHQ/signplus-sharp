using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record Document(
    /// <value>Unique identifier of the document</value>
    [property:
        JsonPropertyName("id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Id = default,
    /// <value>Name of the document</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Name = default,
    /// <value>Filename of the document</value>
    [property:
        JsonPropertyName("filename"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Filename = default,
    /// <value>Number of pages in the document</value>
    [property:
        JsonPropertyName("page_count"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<long> PageCount = default,
    /// <value>List of pages in the document</value>
    [property:
        JsonPropertyName("pages"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<List<Page>> Pages = default
);
