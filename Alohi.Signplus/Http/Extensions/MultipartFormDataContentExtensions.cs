using System.Net.Http.Headers;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Alohi.Signplus.Http.Extensions;

/// <summary>
/// Extension methods for MultipartFormDataContent to serialize objects into multipart/form-data format.
/// Handles primitives, byte arrays (files), nested objects, and Optional wrapper types.
/// </summary>
public static class MultipartFormDataContentExtensions
{
    /// <summary>
    /// Recursively serializes an object into multipart/form-data format.
    /// Maps object properties to form fields, handling files (byte[]), nested objects, and primitives.
    /// Respects JSON property name attributes and Optional wrapper semantics.
    /// </summary>
    /// <param name="formData">The multipart form data content to populate.</param>
    /// <param name="content">The object to serialize.</param>
    /// <param name="options">JSON serializer options for property name mapping.</param>
    /// <returns>The populated multipart form data content for method chaining.</returns>
    public static MultipartFormDataContent AddObject(
        this MultipartFormDataContent formData,
        object content,
        JsonSerializerOptions? options
    )
    {
        foreach (var property in content.GetType().GetProperties())
        {
            var value = property.GetValue(content);
            var key = property.Name;
            var mappedKey = GetPropertyName(property);

            // Handle Optional<T> wrapper
            if (value != null && IsOptionalType(property.PropertyType))
            {
                var optionalValue = GetOptionalValue(value);
                if (optionalValue != null)
                {
                    if (optionalValue is byte[] fileBytes)
                    {
                        var fileContent = new ByteArrayContent(fileBytes);
                        fileContent.Headers.ContentType = new MediaTypeHeaderValue(
                            "application/octet-stream"
                        );

                        formData.Add(fileContent, mappedKey, mappedKey);
                    }
                    else if (!IsPrimitive(optionalValue.GetType()))
                    {
                        var nestedContent = new MultipartFormDataContent().AddObject(
                            optionalValue,
                            options
                        );
                        formData.Add(nestedContent, mappedKey);
                    }
                    else
                    {
                        formData.Add(
                            new StringContent(optionalValue.ToString() ?? string.Empty),
                            mappedKey
                        );
                    }
                }
            }
            else if (value is byte[] fileBytes)
            {
                var fileContent = new ByteArrayContent(fileBytes);
                fileContent.Headers.ContentType = new MediaTypeHeaderValue(
                    "application/octet-stream"
                );

                formData.Add(fileContent, mappedKey, mappedKey);
            }
            else if (value != null && !IsPrimitive(property.PropertyType))
            {
                var nestedContent = new MultipartFormDataContent().AddObject(value, options);
                formData.Add(nestedContent, mappedKey);
            }
            else
            {
                formData.Add(new StringContent(value?.ToString() ?? string.Empty), mappedKey);
            }
        }

        return formData;
    }

    private static bool IsPrimitive(Type type)
    {
        return type.IsPrimitive || type.IsValueType || type == typeof(string);
    }

    private static bool IsOptionalType(Type type)
    {
        return type.IsGenericType && type.GetGenericTypeDefinition().Name == "Optional`1";
    }

    private static object? GetOptionalValue(object optional)
    {
        var hasValueProperty = optional.GetType().GetProperty("IsProvided");
        if (hasValueProperty?.GetValue(optional) is true)
        {
            var valueProperty = optional.GetType().GetProperty("Value");
            return valueProperty?.GetValue(optional);
        }
        return null;
    }

    private static string GetPropertyName(PropertyInfo property)
    {
        var jsonPropertyAttribute = property.GetCustomAttribute<JsonPropertyNameAttribute>();
        if (jsonPropertyAttribute != null)
        {
            return jsonPropertyAttribute.Name;
        }
        return property.Name;
    }
}
