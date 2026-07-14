namespace Alohi.Signplus.Models;

/// <summary>
/// Represents a void/empty response type for use in OneOf unions where no actual data is returned.
/// This is typically used for HTTP responses like 204 No Content.
/// </summary>
public readonly struct VoidType
{
    /// <summary>
    /// Gets the singleton instance of VoidType.
    /// </summary>
    public static VoidType Instance => new();

    /// <summary>
    /// Returns a string representation of the void type.
    /// </summary>
    public override string ToString() => "VoidType";
}
