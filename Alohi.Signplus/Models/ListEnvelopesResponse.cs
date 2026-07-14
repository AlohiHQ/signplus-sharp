using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record ListEnvelopesResponse(
    /// <value>Whether there is a next page</value>
    [property:
        JsonPropertyName("has_next_page"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<bool> HasNextPage = default,
    /// <value>Whether there is a previous page</value>
    [property:
        JsonPropertyName("has_previous_page"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<bool> HasPreviousPage = default,
    [property:
        JsonPropertyName("envelopes"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<List<Envelope>> Envelopes = default
);
