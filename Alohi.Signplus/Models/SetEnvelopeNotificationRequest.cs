using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record SetEnvelopeNotificationRequest(
    [property:
        JsonPropertyName("subject"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Subject = default,
    [property:
        JsonPropertyName("message"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<string?> Message = default,
    [property:
        JsonPropertyName("reminder_interval"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<double?> ReminderInterval = default
);
