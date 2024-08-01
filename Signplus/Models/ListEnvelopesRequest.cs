using System.Text.Json.Serialization;

namespace Signplus.Models;

public record ListEnvelopesRequest(
    /// <value>Name of the envelope</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Name = null,
    /// <value>List of tags</value>
    [property:
        JsonPropertyName("tags"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<string>? Tags = null,
    /// <value>Comment of the envelope</value>
    [property:
        JsonPropertyName("comment"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Comment = null,
    /// <value>List of envelope IDs</value>
    [property:
        JsonPropertyName("ids"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<string>? Ids = null,
    /// <value>List of envelope statuses</value>
    [property:
        JsonPropertyName("statuses"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<EnvelopeStatus>? Statuses = null,
    /// <value>List of folder IDs</value>
    [property:
        JsonPropertyName("folder_ids"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<string>? FolderIds = null,
    /// <value>Whether to only list envelopes in the root folder</value>
    [property:
        JsonPropertyName("only_root_folder"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? OnlyRootFolder = null,
    /// <value>Unix timestamp of the start date</value>
    [property:
        JsonPropertyName("date_from"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? DateFrom = null,
    /// <value>Unix timestamp of the end date</value>
    [property:
        JsonPropertyName("date_to"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? DateTo = null,
    /// <value>Unique identifier of the user</value>
    [property:
        JsonPropertyName("uid"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Uid = null,
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
    /// <value>Field to order envelopes by</value>
    [property:
        JsonPropertyName("order_field"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        EnvelopeOrderField? OrderField = null,
    /// <value>Whether to order envelopes in ascending order</value>
    [property:
        JsonPropertyName("ascending"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Ascending = null,
    /// <value>Whether to include envelopes in the trash</value>
    [property:
        JsonPropertyName("include_trash"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? IncludeTrash = null
);
