using System.Text.Json.Serialization;

namespace Signplus.Models;

public record SetEnvelopeLegalityLevelRequest(
    /// <value>Legal level of the envelope (SES is Simple Electronic Signature, QES_EIDAS is Qualified Electronic Signature, QES_ZERTES is Qualified Electronic Signature with Zertes)</value>
    [property:
        JsonPropertyName("legality_level"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        EnvelopeLegalityLevel? LegalityLevel = null
);
