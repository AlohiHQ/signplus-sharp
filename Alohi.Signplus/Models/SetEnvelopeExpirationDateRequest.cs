using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

public record SetEnvelopeExpirationDateRequest(
    [property:
        JsonPropertyName("expires_at"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)
    ]
        Optional<double?> ExpiresAt = default
);
