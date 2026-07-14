namespace Alohi.Signplus.Http.Serialization;

/// <summary>
/// Defines serialization styles for query parameters, path parameters, and headers according to OpenAPI and RFC-6570 specifications.
/// Each style dictates how values (primitives, arrays, objects) are formatted in URLs.
/// </summary>
public enum SerializationStyle
{
    /// <summary>
    /// Simple style: comma-separated values (e.g., "red,green,blue").
    /// Default for path parameters and headers.
    /// </summary>
    Simple = 0,

    /// <summary>
    /// Label style: dot-prefixed values (e.g., ".red.green.blue").
    /// Used for path parameters with RFC-6570 label expansion.
    /// </summary>
    Label = 1,

    /// <summary>
    /// Matrix style: semicolon-prefixed key-value pairs (e.g., ";color=red;color=green").
    /// Used for path parameters with RFC-6570 matrix expansion.
    /// </summary>
    Matrix = 2,

    /// <summary>
    /// Form style: ampersand-separated key-value pairs (e.g., "color=red&color=green").
    /// Default for query parameters.
    /// </summary>
    Form = 3,

    /// <summary>
    /// Space-delimited style: space-separated values (e.g., "color=red green blue").
    /// Used for query parameters with space separators.
    /// </summary>
    SpaceDelimited = 4,

    /// <summary>
    /// Pipe-delimited style: pipe-separated values (e.g., "color=red|green|blue").
    /// Used for query parameters with pipe separators.
    /// </summary>
    PipeDelimited = 5,

    /// <summary>
    /// Deep object style: nested bracket notation (e.g., "color[R]=100&color[G]=200").
    /// Used for query parameters representing nested objects.
    /// </summary>
    DeepObject = 6,
}
