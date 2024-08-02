using System.Text.Json.Serialization;

namespace Signplus.Models;

public record ListEnvelopesResponse(
    /// <value>Whether there is a next page</value>
    [property:
        JsonPropertyName("has_next_page"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? HasNextPage = null,
    /// <value>Whether there is a previous page</value>
    [property:
        JsonPropertyName("has_previous_page"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? HasPreviousPage = null,
    [property:
        JsonPropertyName("envelopes"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<Envelope>? Envelopes = null
);
