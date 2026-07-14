namespace Alohi.Signplus.Http.Serialization;

/// <summary>
/// Serialization styles specifically for query parameters according to OpenAPI specification.
/// Subset of SerializationStyle containing only styles valid for query parameters.
/// </summary>
public enum QuerySerializationStyle
{
    /// <summary>
    /// Form style: ampersand-separated key-value pairs (default for query parameters).
    /// Example: ?color=red&color=green
    /// </summary>
    Form = SerializationStyle.Form,

    /// <summary>
    /// Space-delimited style: space-separated values.
    /// Example: ?color=red%20green%20blue
    /// </summary>
    SpaceDelimited = SerializationStyle.SpaceDelimited,

    /// <summary>
    /// Pipe-delimited style: pipe-separated values.
    /// Example: ?color=red|green|blue
    /// </summary>
    PipeDelimited = SerializationStyle.PipeDelimited,

    /// <summary>
    /// Deep object style: nested bracket notation for objects.
    /// Example: ?color[R]=100&color[G]=200&color[B]=50
    /// </summary>
    DeepObject = SerializationStyle.DeepObject,
}
