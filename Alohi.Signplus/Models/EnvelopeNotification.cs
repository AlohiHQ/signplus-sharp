using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record EnvelopeNotification(
    /// <value>Subject of the notification</value>
    [property:
        JsonPropertyName("subject"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Subject = default,
    /// <value>Message of the notification</value>
    [property:
        JsonPropertyName("message"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<string> Message = default,
    /// <value>Interval in days to send reminder</value>
    [property:
        JsonPropertyName("reminder_interval"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ] Optional<long> ReminderInterval = default
);
