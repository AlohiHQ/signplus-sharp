using System.Collections.Generic;
using System.Text.Json;
using Alohi.Signplus.Models;

namespace Alohi.Signplus.Validation;

/// <summary>
/// Helper class for custom JSON deserialization with required field validation
/// </summary>
public static class DeserializationValidation
{
    /// <summary>
    /// Deserializes JSON content with validation for required fields
    /// </summary>
    /// <typeparam name="T">The type to deserialize to</typeparam>
    /// <param name="jsonContent">The JSON content to deserialize</param>
    /// <param name="jsonSerializerOptions">JSON serializer options</param>
    /// <returns>The deserialized object</returns>
    /// <exception cref="JsonException">Thrown when required fields are missing from the JSON</exception>
    public static T DeserializeWithRequiredFieldValidation<T>(
        string jsonContent,
        JsonSerializerOptions jsonSerializerOptions
    )
    {
        // Empty/whitespace body is valid for success responses (204 No
        // Content, or 200s where the API legitimately returns no payload).
        // Return the type's default rather than throwing — JsonDocument.Parse
        // on `""` raises JsonReaderException, which would otherwise take out
        // every call site even when the HTTP layer reported success.
        if (string.IsNullOrWhiteSpace(jsonContent))
        {
            return default!;
        }

        // Parse JSON to check for missing required fields
        using var document = JsonDocument.Parse(jsonContent);
        var root = document.RootElement;

        // Validate required fields for the specific response type
        ValidateRequiredFieldsForResponse<T>(root);

        // Deserialize normally after validation
        return JsonSerializer.Deserialize<T>(jsonContent, jsonSerializerOptions)
            ?? throw new Exception("Failed to deserialize response.");
    }

    private static readonly Dictionary<Type, Action<JsonElement>> ValidationMethods = new()
    {
        {
            typeof(global::Alohi.Signplus.Models.CreateEnvelopeRequest),
            ValidateRequiredFieldsForCreateEnvelopeRequest
        },
        {
            typeof(global::Alohi.Signplus.Models.CreateEnvelopeFromTemplateRequest),
            ValidateRequiredFieldsForCreateEnvelopeFromTemplateRequest
        },
        {
            typeof(global::Alohi.Signplus.Models.SetEnvelopeDynamicFieldsRequest),
            ValidateRequiredFieldsForSetEnvelopeDynamicFieldsRequest
        },
        {
            typeof(global::Alohi.Signplus.Models.SetEnvelopeAttachmentsSettingsRequest),
            ValidateRequiredFieldsForSetEnvelopeAttachmentsSettingsRequest
        },
        {
            typeof(global::Alohi.Signplus.Models.SetEnvelopeAttachmentsPlaceholdersRequest),
            ValidateRequiredFieldsForSetEnvelopeAttachmentsPlaceholdersRequest
        },
        {
            typeof(global::Alohi.Signplus.Models.SetEnvelopeCommentRequest),
            ValidateRequiredFieldsForSetEnvelopeCommentRequest
        },
        {
            typeof(global::Alohi.Signplus.Models.SetEnvelopeExpirationRequest),
            ValidateRequiredFieldsForSetEnvelopeExpirationRequest
        },
        {
            typeof(global::Alohi.Signplus.Models.AddAnnotationRequest),
            ValidateRequiredFieldsForAddAnnotationRequest
        },
        {
            typeof(global::Alohi.Signplus.Models.CreateTemplateRequest),
            ValidateRequiredFieldsForCreateTemplateRequest
        },
        {
            typeof(global::Alohi.Signplus.Models.AddTemplateDocumentRequest),
            ValidateRequiredFieldsForAddTemplateDocumentRequest
        },
        {
            typeof(global::Alohi.Signplus.Models.AddTemplateSigningStepsRequest),
            ValidateRequiredFieldsForAddTemplateSigningStepsRequest
        },
        {
            typeof(global::Alohi.Signplus.Models.RenameTemplateRequest),
            ValidateRequiredFieldsForRenameTemplateRequest
        },
        {
            typeof(global::Alohi.Signplus.Models.SetTemplateCommentRequest),
            ValidateRequiredFieldsForSetTemplateCommentRequest
        },
        {
            typeof(global::Alohi.Signplus.Models.CreateWebhookRequest),
            ValidateRequiredFieldsForCreateWebhookRequest
        },
        { typeof(global::Alohi.Signplus.Models.Recipient), ValidateRequiredFieldsForRecipient },
        {
            typeof(global::Alohi.Signplus.Models.AttachmentPlaceholderRequest),
            ValidateRequiredFieldsForAttachmentPlaceholderRequest
        },
    };

    private static void ValidateRequiredFieldsForResponse<T>(JsonElement root)
    {
        if (ValidationMethods.TryGetValue(typeof(T), out var validator))
        {
            validator(root);
        }
    }

    private static void ValidateRequiredFieldsForCreateEnvelopeRequest(JsonElement root)
    {
        // Non-nullable required fields - must be present and not null
        var nonNullableRequiredFields = new[] { "name", "legality_level" };

        var missingFields = new List<string>();

        // Check non-nullable required fields
        foreach (var field in nonNullableRequiredFields)
        {
            if (
                !root.TryGetProperty(field, out var property)
                || property.ValueKind == JsonValueKind.Null
            )
            {
                missingFields.Add(field);
            }
        }

        if (missingFields.Any())
        {
            throw new JsonException(
                $"Required fields are missing from JSON response: {string.Join(", ", missingFields)}"
            );
        }
    }

    private static void ValidateRequiredFieldsForCreateEnvelopeFromTemplateRequest(JsonElement root)
    {
        // Non-nullable required fields - must be present and not null
        var nonNullableRequiredFields = new[] { "name" };

        var missingFields = new List<string>();

        // Check non-nullable required fields
        foreach (var field in nonNullableRequiredFields)
        {
            if (
                !root.TryGetProperty(field, out var property)
                || property.ValueKind == JsonValueKind.Null
            )
            {
                missingFields.Add(field);
            }
        }

        if (missingFields.Any())
        {
            throw new JsonException(
                $"Required fields are missing from JSON response: {string.Join(", ", missingFields)}"
            );
        }
    }

    private static void ValidateRequiredFieldsForSetEnvelopeDynamicFieldsRequest(JsonElement root)
    {
        // Non-nullable required fields - must be present and not null
        var nonNullableRequiredFields = new[] { "dynamic_fields" };

        var missingFields = new List<string>();

        // Check non-nullable required fields
        foreach (var field in nonNullableRequiredFields)
        {
            if (
                !root.TryGetProperty(field, out var property)
                || property.ValueKind == JsonValueKind.Null
            )
            {
                missingFields.Add(field);
            }
        }

        if (missingFields.Any())
        {
            throw new JsonException(
                $"Required fields are missing from JSON response: {string.Join(", ", missingFields)}"
            );
        }
    }

    private static void ValidateRequiredFieldsForSetEnvelopeAttachmentsSettingsRequest(
        JsonElement root
    )
    {
        // Non-nullable required fields - must be present and not null
        var nonNullableRequiredFields = new[] { "settings" };

        var missingFields = new List<string>();

        // Check non-nullable required fields
        foreach (var field in nonNullableRequiredFields)
        {
            if (
                !root.TryGetProperty(field, out var property)
                || property.ValueKind == JsonValueKind.Null
            )
            {
                missingFields.Add(field);
            }
        }

        if (missingFields.Any())
        {
            throw new JsonException(
                $"Required fields are missing from JSON response: {string.Join(", ", missingFields)}"
            );
        }
    }

    private static void ValidateRequiredFieldsForSetEnvelopeAttachmentsPlaceholdersRequest(
        JsonElement root
    )
    {
        // Non-nullable required fields - must be present and not null
        var nonNullableRequiredFields = new[] { "placeholders" };

        var missingFields = new List<string>();

        // Check non-nullable required fields
        foreach (var field in nonNullableRequiredFields)
        {
            if (
                !root.TryGetProperty(field, out var property)
                || property.ValueKind == JsonValueKind.Null
            )
            {
                missingFields.Add(field);
            }
        }

        if (missingFields.Any())
        {
            throw new JsonException(
                $"Required fields are missing from JSON response: {string.Join(", ", missingFields)}"
            );
        }
    }

    private static void ValidateRequiredFieldsForSetEnvelopeCommentRequest(JsonElement root)
    {
        // Non-nullable required fields - must be present and not null
        var nonNullableRequiredFields = new[] { "comment" };

        var missingFields = new List<string>();

        // Check non-nullable required fields
        foreach (var field in nonNullableRequiredFields)
        {
            if (
                !root.TryGetProperty(field, out var property)
                || property.ValueKind == JsonValueKind.Null
            )
            {
                missingFields.Add(field);
            }
        }

        if (missingFields.Any())
        {
            throw new JsonException(
                $"Required fields are missing from JSON response: {string.Join(", ", missingFields)}"
            );
        }
    }

    private static void ValidateRequiredFieldsForSetEnvelopeExpirationRequest(JsonElement root)
    {
        // Non-nullable required fields - must be present and not null
        var nonNullableRequiredFields = new[] { "expires_at" };

        var missingFields = new List<string>();

        // Check non-nullable required fields
        foreach (var field in nonNullableRequiredFields)
        {
            if (
                !root.TryGetProperty(field, out var property)
                || property.ValueKind == JsonValueKind.Null
            )
            {
                missingFields.Add(field);
            }
        }

        if (missingFields.Any())
        {
            throw new JsonException(
                $"Required fields are missing from JSON response: {string.Join(", ", missingFields)}"
            );
        }
    }

    private static void ValidateRequiredFieldsForAddAnnotationRequest(JsonElement root)
    {
        // Non-nullable required fields - must be present and not null
        var nonNullableRequiredFields = new[]
        {
            "document_id",
            "page",
            "x",
            "y",
            "width",
            "height",
            "type",
        };

        var missingFields = new List<string>();

        // Check non-nullable required fields
        foreach (var field in nonNullableRequiredFields)
        {
            if (
                !root.TryGetProperty(field, out var property)
                || property.ValueKind == JsonValueKind.Null
            )
            {
                missingFields.Add(field);
            }
        }

        if (missingFields.Any())
        {
            throw new JsonException(
                $"Required fields are missing from JSON response: {string.Join(", ", missingFields)}"
            );
        }
    }

    private static void ValidateRequiredFieldsForCreateTemplateRequest(JsonElement root)
    {
        // Non-nullable required fields - must be present and not null
        var nonNullableRequiredFields = new[] { "name" };

        var missingFields = new List<string>();

        // Check non-nullable required fields
        foreach (var field in nonNullableRequiredFields)
        {
            if (
                !root.TryGetProperty(field, out var property)
                || property.ValueKind == JsonValueKind.Null
            )
            {
                missingFields.Add(field);
            }
        }

        if (missingFields.Any())
        {
            throw new JsonException(
                $"Required fields are missing from JSON response: {string.Join(", ", missingFields)}"
            );
        }
    }

    private static void ValidateRequiredFieldsForAddTemplateDocumentRequest(JsonElement root)
    {
        // Non-nullable required fields - must be present and not null
        var nonNullableRequiredFields = new[] { "file" };

        var missingFields = new List<string>();

        // Check non-nullable required fields
        foreach (var field in nonNullableRequiredFields)
        {
            if (
                !root.TryGetProperty(field, out var property)
                || property.ValueKind == JsonValueKind.Null
            )
            {
                missingFields.Add(field);
            }
        }

        if (missingFields.Any())
        {
            throw new JsonException(
                $"Required fields are missing from JSON response: {string.Join(", ", missingFields)}"
            );
        }
    }

    private static void ValidateRequiredFieldsForAddTemplateSigningStepsRequest(JsonElement root)
    {
        // Non-nullable required fields - must be present and not null
        var nonNullableRequiredFields = new[] { "signing_steps" };

        var missingFields = new List<string>();

        // Check non-nullable required fields
        foreach (var field in nonNullableRequiredFields)
        {
            if (
                !root.TryGetProperty(field, out var property)
                || property.ValueKind == JsonValueKind.Null
            )
            {
                missingFields.Add(field);
            }
        }

        if (missingFields.Any())
        {
            throw new JsonException(
                $"Required fields are missing from JSON response: {string.Join(", ", missingFields)}"
            );
        }
    }

    private static void ValidateRequiredFieldsForRenameTemplateRequest(JsonElement root)
    {
        // Non-nullable required fields - must be present and not null
        var nonNullableRequiredFields = new[] { "name" };

        var missingFields = new List<string>();

        // Check non-nullable required fields
        foreach (var field in nonNullableRequiredFields)
        {
            if (
                !root.TryGetProperty(field, out var property)
                || property.ValueKind == JsonValueKind.Null
            )
            {
                missingFields.Add(field);
            }
        }

        if (missingFields.Any())
        {
            throw new JsonException(
                $"Required fields are missing from JSON response: {string.Join(", ", missingFields)}"
            );
        }
    }

    private static void ValidateRequiredFieldsForSetTemplateCommentRequest(JsonElement root)
    {
        // Non-nullable required fields - must be present and not null
        var nonNullableRequiredFields = new[] { "comment" };

        var missingFields = new List<string>();

        // Check non-nullable required fields
        foreach (var field in nonNullableRequiredFields)
        {
            if (
                !root.TryGetProperty(field, out var property)
                || property.ValueKind == JsonValueKind.Null
            )
            {
                missingFields.Add(field);
            }
        }

        if (missingFields.Any())
        {
            throw new JsonException(
                $"Required fields are missing from JSON response: {string.Join(", ", missingFields)}"
            );
        }
    }

    private static void ValidateRequiredFieldsForCreateWebhookRequest(JsonElement root)
    {
        // Non-nullable required fields - must be present and not null
        var nonNullableRequiredFields = new[] { "event", "target" };

        var missingFields = new List<string>();

        // Check non-nullable required fields
        foreach (var field in nonNullableRequiredFields)
        {
            if (
                !root.TryGetProperty(field, out var property)
                || property.ValueKind == JsonValueKind.Null
            )
            {
                missingFields.Add(field);
            }
        }

        if (missingFields.Any())
        {
            throw new JsonException(
                $"Required fields are missing from JSON response: {string.Join(", ", missingFields)}"
            );
        }
    }

    private static void ValidateRequiredFieldsForRecipient(JsonElement root)
    {
        // Non-nullable required fields - must be present and not null
        var nonNullableRequiredFields = new[] { "name", "email", "role" };

        var missingFields = new List<string>();

        // Check non-nullable required fields
        foreach (var field in nonNullableRequiredFields)
        {
            if (
                !root.TryGetProperty(field, out var property)
                || property.ValueKind == JsonValueKind.Null
            )
            {
                missingFields.Add(field);
            }
        }

        if (missingFields.Any())
        {
            throw new JsonException(
                $"Required fields are missing from JSON response: {string.Join(", ", missingFields)}"
            );
        }
    }

    private static void ValidateRequiredFieldsForAttachmentPlaceholderRequest(JsonElement root)
    {
        // Non-nullable required fields - must be present and not null
        var nonNullableRequiredFields = new[] { "recipient_id", "name", "required", "multiple" };

        var missingFields = new List<string>();

        // Check non-nullable required fields
        foreach (var field in nonNullableRequiredFields)
        {
            if (
                !root.TryGetProperty(field, out var property)
                || property.ValueKind == JsonValueKind.Null
            )
            {
                missingFields.Add(field);
            }
        }

        if (missingFields.Any())
        {
            throw new JsonException(
                $"Required fields are missing from JSON response: {string.Join(", ", missingFields)}"
            );
        }
    }
}
