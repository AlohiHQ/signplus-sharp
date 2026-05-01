using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record SigningStepsRecipients2(
    [property:
        JsonPropertyName("id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Id = default,
    [property:
        JsonPropertyName("uid"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Uid = default,
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Name = default,
    [property:
        JsonPropertyName("email"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Email = default,
    [property:
        JsonPropertyName("role"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Role = default
);
