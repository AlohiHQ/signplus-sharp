using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record ListEnvelopesRequest(
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Name = default,
    [property:
        JsonPropertyName("tags"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<string>?> Tags = default,
    [property:
        JsonPropertyName("comment"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Comment = default,
    [property:
        JsonPropertyName("ids"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<string>?> Ids = default,
    [property:
        JsonPropertyName("statuses"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<string>?> Statuses = default,
    [property:
        JsonPropertyName("folder_ids"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<string>?> FolderIds = default,
    [property:
        JsonPropertyName("only_root_folder"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> OnlyRootFolder = default,
    [property:
        JsonPropertyName("date_from"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> DateFrom = default,
    [property:
        JsonPropertyName("date_to"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> DateTo = default,
    [property:
        JsonPropertyName("uid"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Uid = default,
    [property:
        JsonPropertyName("first"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> First = default,
    [property:
        JsonPropertyName("last"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Last = default,
    [property:
        JsonPropertyName("after"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> After = default,
    [property:
        JsonPropertyName("before"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Before = default,
    [property:
        JsonPropertyName("order_field"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> OrderField = default,
    [property:
        JsonPropertyName("ascending"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Ascending = default,
    [property:
        JsonPropertyName("include_trash"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> IncludeTrash = default
);
