namespace Alohi.Signplus.Http.Serialization;

/// <summary>
/// Serialization styles specifically for path parameters according to OpenAPI specification.
/// Subset of SerializationStyle containing only styles valid for path parameters.
/// </summary>
public enum PathSerializationStyle
{
    /// <summary>
    /// Simple style: comma-separated values (default for path parameters).
    /// Example: /users/red,green,blue
    /// </summary>
    Simple = SerializationStyle.Simple,

    /// <summary>
    /// Label style: dot-prefixed values.
    /// Example: /users/.red.green.blue
    /// </summary>
    Label = SerializationStyle.Label,

    /// <summary>
    /// Matrix style: semicolon-prefixed key-value pairs.
    /// Example: /users;color=red;color=green
    /// </summary>
    Matrix = SerializationStyle.Matrix,
}
