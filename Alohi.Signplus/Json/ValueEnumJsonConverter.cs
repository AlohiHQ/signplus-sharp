using System.Text.Json;
using System.Text.Json.Serialization;
using Alohi.Signplus.Models;

namespace Alohi.Signplus.Json;

/// <summary>
/// JSON converter for ValueEnum types, handling serialization/deserialization of enum-like values.
/// Supports string, integer, floating-point, and boolean enum values.
/// Serializes as the raw value (e.g., "draft" for string enums, 1 for int enums).
/// </summary>
/// <typeparam name="TValueEnum">The ValueEnum wrapper type.</typeparam>
/// <typeparam name="TEnumType">The underlying value type (string, int, long, double, float, or bool).</typeparam>
internal class ValueEnumJsonConverter<TValueEnum, TEnumType> : JsonConverter<TValueEnum>
    where TValueEnum : ValueEnum<TEnumType>, new()
{
    /// <summary>
    /// Deserializes a JSON value into a ValueEnum instance.
    /// Reads the appropriate JSON token based on the enum's underlying type.
    /// </summary>
    public override TValueEnum? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        object? value = null;

        if (typeof(TEnumType) == typeof(string))
        {
            value = reader.GetString();
        }
        else if (typeof(TEnumType) == typeof(int) || typeof(TEnumType) == typeof(long))
        {
            value = reader.GetInt64();
        }
        else if (typeof(TEnumType) == typeof(double) || typeof(TEnumType) == typeof(float))
        {
            value = reader.GetDouble();
        }
        else if (typeof(TEnumType) == typeof(bool))
        {
            value = reader.GetBoolean();
        }
        else
        {
            throw new JsonException(
                $"Attempted to deserialize unsupported ValueEnum type: {typeof(TEnumType)}"
            );
        }

        if (value is null)
        {
            return null;
        }

        return new TValueEnum { Value = (TEnumType)Convert.ChangeType(value, typeof(TEnumType)) };
    }

    /// <summary>
    /// Serializes a ValueEnum instance to JSON by writing its raw value.
    /// The wrapper type is transparent - only the underlying value is written to JSON.
    /// </summary>
    public override void Write(
        Utf8JsonWriter writer,
        TValueEnum valueEnum,
        JsonSerializerOptions options
    )
    {
        JsonSerializer.Serialize(writer, valueEnum.Value, options);
    }
}
