using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record ListEnvelopesRequest(
    /// <value>Name of the envelope</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Name = default,
    /// <value>List of tags</value>
    [property:
        JsonPropertyName("tags"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<List<string>> Tags = default,
    /// <value>Comment of the envelope</value>
    [property:
        JsonPropertyName("comment"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Comment = default,
    /// <value>List of envelope IDs</value>
    [property:
        JsonPropertyName("ids"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<List<string>> Ids = default,
    /// <value>List of envelope statuses</value>
    [property:
        JsonPropertyName("statuses"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<List<EnvelopeStatus>> Statuses = default,
    /// <value>List of folder IDs</value>
    [property:
        JsonPropertyName("folder_ids"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<List<string>> FolderIds = default,
    /// <value>Whether to only list envelopes in the root folder</value>
    [property:
        JsonPropertyName("only_root_folder"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<bool> OnlyRootFolder = default,
    /// <value>Unix timestamp of the start date</value>
    [property:
        JsonPropertyName("date_from"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<long> DateFrom = default,
    /// <value>Unix timestamp of the end date</value>
    [property:
        JsonPropertyName("date_to"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<long> DateTo = default,
    /// <value>Unique identifier of the user</value>
    [property:
        JsonPropertyName("uid"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Uid = default,
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
    /// <value>Field to order envelopes by</value>
    [property:
        JsonPropertyName("order_field"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<EnvelopeOrderField> OrderField = default,
    /// <value>Whether to order envelopes in ascending order</value>
    [property:
        JsonPropertyName("ascending"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<bool> Ascending = default,
    /// <value>Whether to include envelopes in the trash</value>
    [property:
        JsonPropertyName("include_trash"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<bool> IncludeTrash = default
);
