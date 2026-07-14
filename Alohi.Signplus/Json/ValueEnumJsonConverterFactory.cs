using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using Alohi.Signplus.Models;

namespace Alohi.Signplus.Json;

/// <summary>
/// Factory for creating ValueEnumJsonConverter instances for enum-like ValueEnum types.
/// Detects types inheriting from ValueEnum and creates converters that serialize/deserialize as raw values.
/// </summary>
internal class ValueEnumJsonConverterFactory : JsonConverterFactory
{
    /// <summary>
    /// Determines if this factory can create a converter for the given type.
    /// Returns true for types that inherit from the generic ValueEnum base class.
    /// </summary>
    public override bool CanConvert(Type typeToConvert)
    {
        if (typeToConvert.BaseType is null || !typeToConvert.BaseType.IsGenericType)
        {
            return false;
        }

        var baseType = typeToConvert.BaseType.GetGenericTypeDefinition();
        return baseType == typeof(ValueEnum<>);
    }

    /// <summary>
    /// Creates a ValueEnumJsonConverter instance for the specified ValueEnum type.
    /// Extracts the underlying value type from ValueEnum and constructs the appropriate generic converter.
    /// </summary>
    public override JsonConverter? CreateConverter(
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        var genericArguments =
            typeToConvert.BaseType?.GetGenericArguments()
            ?? throw new InvalidOperationException("Failed to get generic argument from ValueEnum");
        var jsonConverterType = typeof(ValueEnumJsonConverter<,>).MakeGenericType(
            typeToConvert,
            genericArguments[0]
        );
        var instance =
            Activator.CreateInstance(jsonConverterType)
            ?? throw new InvalidOperationException(
                "Failed to create ValueEnumJsonConverter instance"
            );
        return (JsonConverter)instance;
    }
}
