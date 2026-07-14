using System.Collections;
using System.Text.Json.Serialization;

namespace Alohi.Signplus.Http.Serialization;

public static class Serializer
{
    /// <summary>
    /// Serializes types into strings based on the RFC-6570 URI Template and OpenAPI specifications.
    /// <see cref="https://datatracker.ietf.org/doc/html/rfc6570"/>
    /// <see cref="https://swagger.io/docs/specification/serialization/"/>
    /// </summary>
    public static string Serialize<T>(
        string key,
        T value,
        SerializationStyle style,
        bool explode = true,
        bool shouldUrlEncode = true
    )
    {
        return value switch
        {
            null or string or bool or int or long or double => SerializePrimitive(
                key,
                value,
                style,
                shouldUrlEncode
            ),
            IEnumerable e => SerializeEnumerable(key, e, style, explode, shouldUrlEncode),
            object o => SerializeObject(key, o, style, explode, shouldUrlEncode),
        };
    }

    private static string SerializeValue(object? value, bool shouldUrlEncode = true)
    {
        return value switch
            {
                null => "null",
                string s => shouldUrlEncode ? Uri.EscapeDataString(s) : s,
                bool b => b.ToString().ToLowerInvariant(),
                int or long or double => value.ToString(),
                IEnumerable e => SerializeEnumerable(
                    string.Empty,
                    e,
                    SerializationStyle.Simple,
                    false
                ),
                not null => SerializeObject(string.Empty, value, SerializationStyle.Simple, false),
            } ?? string.Empty;
    }

    private static string SerializePrimitive(
        string key,
        object? value,
        SerializationStyle style,
        bool shouldUrlEncode = true
    )
    {
        return style switch
        {
            SerializationStyle.Label => $".{SerializeValue(value, shouldUrlEncode)}",
            SerializationStyle.Matrix => $";{SerializeValue(value, shouldUrlEncode)}",
            SerializationStyle.Form => $"{key}={SerializeValue(value, shouldUrlEncode)}",
            _ => SerializeValue(value, shouldUrlEncode),
        };
    }

    private static string SerializeEnumerable(
        string key,
        IEnumerable enumerable,
        SerializationStyle style,
        bool explode,
        bool shouldUrlEncode = true
    )
    {
        var array = enumerable as object[] ?? enumerable.Cast<object>().ToArray();
        var serializedValues = array.Select((object o) => SerializeValue(o, shouldUrlEncode));

        switch (style)
        {
            case SerializationStyle.Simple:
                return string.Join(",", serializedValues);
            case SerializationStyle.Label:
                return explode
                    ? string.Join(".", serializedValues)
                    : $".{string.Join(",", serializedValues)}";
            case SerializationStyle.Matrix:
                return explode
                    ? string.Join($";{key}=", serializedValues)
                    : $";{key}={string.Join(",", serializedValues)}";
        }

        if (explode)
            return string.Join(
                $"&",
                array.Select(e => Serialize(key, e, SerializationStyle.Form, explode))
            );

        var separator = style switch
        {
            SerializationStyle.SpaceDelimited => " ",
            SerializationStyle.PipeDelimited => "|",
            _ => ",",
        };

        return $"{key}={string.Join(separator, serializedValues)}";
    }

    private static string SerializeObject<T>(
        string key,
        T o,
        SerializationStyle style,
        bool explode,
        bool shouldUrlEncode = true
    )
        where T : class
    {
        var properties = o.GetType()
            .GetProperties()
            .Select(p =>
            {
                // Use JsonPropertyNameAttribute for property name if available
                var name = p.GetCustomAttributes(typeof(JsonPropertyNameAttribute), false)
                    .FirstOrDefault()
                    is JsonPropertyNameAttribute jsonProperty
                    ? jsonProperty.Name
                    : p.Name;
                var value = p.GetValue(o);

                // Handle Optional<T> fields - only include if they have a value
                if (
                    value != null
                    && value.GetType().IsGenericType
                    && value.GetType().GetGenericTypeDefinition().Name == "Optional`1"
                )
                {
                    var isProvidedProperty = value.GetType().GetProperty("IsProvided");
                    if (isProvidedProperty != null)
                    {
                        var isProvided = (bool)isProvidedProperty.GetValue(value);
                        if (!isProvided)
                        {
                            return (name, value: null); // This will be filtered out by Where clause
                        }

                        // Get the actual value from Optional<T>
                        var valueProperty = value.GetType().GetProperty("Value");
                        if (valueProperty != null)
                        {
                            value = valueProperty.GetValue(value);
                        }
                    }
                }

                return (name, value);
            })
            .Where(p => p.value != null);

        switch (style)
        {
            case SerializationStyle.Simple:
                return string.Join(
                    ",",
                    explode
                        ? properties.Select(p =>
                            $"{p.name}={SerializeValue(p.value, shouldUrlEncode)}"
                        )
                        : properties.Select(p =>
                            $"{p.name},{SerializeValue(p.value, shouldUrlEncode)}"
                        )
                );
            case SerializationStyle.Label:
                return explode
                    ? string.Join(
                        ".",
                        properties.Select(p =>
                            $"{p.name}={SerializeValue(p.value, shouldUrlEncode)}"
                        )
                    )
                    : $"."
                        + string.Join(
                            ",",
                            properties.Select(p =>
                                $"{p.name}={SerializeValue(p.value, shouldUrlEncode)}"
                            )
                        );
            case SerializationStyle.Matrix:
                return explode
                    ? string.Join(
                        $";",
                        properties.Select(p =>
                            $"{p.name}={SerializeValue(p.value, shouldUrlEncode)}"
                        )
                    )
                    : $";{string.Join(",", properties.Select(p => $"{p.name}={SerializeValue(p.value, shouldUrlEncode)}"))}";
            case SerializationStyle.DeepObject:
                return string.Join(
                    "&",
                    properties.Select(p =>
                        $"{key}[{p.name}]={SerializeValue(p.value, shouldUrlEncode)}"
                    )
                );
            default:
                // Form style
                return explode
                    ? string.Join(
                        "&",
                        properties.Select(p =>
                            $"{p.name}={SerializeValue(p.value, shouldUrlEncode)}"
                        )
                    )
                    : $"{key}={string.Join(",", properties.Select((p) => $"{p.name},{SerializeValue(p.value, shouldUrlEncode)}"))}";
        }
    }
}
