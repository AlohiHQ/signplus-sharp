using System.Net.Http.Headers;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Alohi.Signplus.Http.Extensions;

public static class MultipartFormDataContentExtensions
{
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

            if (value is byte[] fileBytes)
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
