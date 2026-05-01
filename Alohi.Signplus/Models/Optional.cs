using System.Text.Json;
using System.Text.Json.Serialization;

namespace Alohi.Signplus.Models;

/// <summary>
/// Shared helper for nullable type checking
/// </summary>
internal static class NullableTypeHelper
{
    /// <summary>
    /// Checks if a type is nullable at runtime
    /// </summary>
    public static bool IsNullableType(Type type)
    {
        // All reference types are nullable at runtime (string, object, etc.)
        if (!type.IsValueType)
            return true;

        // For value types, only Nullable<T> is nullable
        return Nullable.GetUnderlyingType(type) != null;
    }
}

/// <summary>
/// Represents an optional value that can be either provided or not provided.
/// This allows distinguishing between "not provided" and "explicitly null" for optional fields.
/// </summary>
/// <typeparam name="T">The type of the optional value</typeparam>
public readonly struct Optional<T>
{
    private readonly T? _value;
    private readonly bool _hasValue;

    private Optional(T? value, bool hasValue)
    {
        _value = value;
        _hasValue = hasValue;
    }

    /// <summary>
    /// Creates an Optional that represents a not provided value
    /// </summary>
    public static Optional<T> NotProvided() => new(default, false);

    /// <summary>
    /// Creates an Optional that represents a provided value (which can be null for nullable types)
    /// </summary>
    public static Optional<T> Of(T? value)
    {
        return new(value, true);
    }

    /// <summary>
    /// Returns true if the value was not provided
    /// </summary>
    public bool IsNotProvided => !_hasValue;

    /// <summary>
    /// Returns true if the value was provided (even if it's null)
    /// </summary>
    public bool IsProvided => _hasValue;

    /// <summary>
    /// Gets the value if it was provided, throws if not provided
    /// </summary>
    public T? Value =>
        _hasValue ? _value : throw new InvalidOperationException("Value is not provided");

    /// <summary>
    /// Implicit conversion from T? to Optional<T>
    /// </summary>
    public static implicit operator Optional<T>(T? value) => Of(value);

    /// <summary>
    /// Returns a string representation of the Optional
    /// - Omitted (NotProvided) → empty string (like required nullable)
    /// - Present with value → the value
    /// - Present but null → empty string (like required nullable)
    /// </summary>
    public override string ToString()
    {
        if (!_hasValue)
            return ""; // Omitted = empty (like required nullable)
        return _value?.ToString() ?? ""; // Present but null = empty (like required nullable)
    }
}

/// <summary>
/// JSON converter factory for Optional<T> that creates converters for specific types
/// </summary>
public class OptionalConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        return typeToConvert.IsGenericType
            && typeToConvert.GetGenericTypeDefinition() == typeof(Optional<>);
    }

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        var valueType = typeToConvert.GetGenericArguments()[0];
        var converterType = typeof(OptionalConverter<>).MakeGenericType(valueType);
        return (JsonConverter)Activator.CreateInstance(converterType)!;
    }
}

/// <summary>
/// JSON converter for Optional<T> that handles serialization and deserialization
/// </summary>
public class OptionalConverter<T> : JsonConverter<Optional<T>>
{
    public override Optional<T> Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            // For nullable types, allow null
            if (NullableTypeHelper.IsNullableType(typeof(T)))
                return Optional<T>.Of(default(T));

            // For non-nullable types, this is a schema violation
            throw new JsonException(
                $"Property was present with null value, but schema requires non-null for type {typeof(T).Name}. Use Optional<{typeof(T).Name}?> for nullable fields."
            );
        }

        var value = JsonSerializer.Deserialize<T>(ref reader, options);
        return Optional<T>.Of(value);
    }

    public override void Write(
        Utf8JsonWriter writer,
        Optional<T> value,
        JsonSerializerOptions options
    )
    {
        if (value.IsNotProvided)
            return; // Don't write anything - field will be omitted from JSON

        // If the value is null, only write null for nullable types
        if (value.Value == null)
        {
            // Check if this is a nullable type by looking at the generic type definition
            if (NullableTypeHelper.IsNullableType(typeof(T)))
                writer.WriteNullValue();
            else
            {
                // For non-nullable types, this is a programming error
                throw new InvalidOperationException(
                    $"Cannot serialize null value for non-nullable Optional<{typeof(T).Name}>. Use Optional<{typeof(T).Name}>.NotProvided() to omit the field, or use Optional<{typeof(T).Name}?> for nullable fields."
                );
            }
        }
        else
        {
            JsonSerializer.Serialize(writer, value.Value, options);
        }
    }
}
