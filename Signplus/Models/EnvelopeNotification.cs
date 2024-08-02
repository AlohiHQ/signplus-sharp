using System.Text.Json.Serialization;

namespace Signplus.Models;

public record EnvelopeNotification(
    /// <value>Subject of the notification</value>
    [property:
        JsonPropertyName("subject"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Subject = null,
    /// <value>Message of the notification</value>
    [property:
        JsonPropertyName("message"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Message = null,
    /// <value>Interval in days to send reminder</value>
    [property:
        JsonPropertyName("reminder_interval"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? ReminderInterval = null
);
