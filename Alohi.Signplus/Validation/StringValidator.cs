namespace Alohi.Signplus.Validation;

using FluentValidation;

/// <summary>
/// Fluent validator for string values with support for length and pattern constraints.
/// Provides chainable methods for adding validation rules to string properties.
/// </summary>
public class StringValidator : AbstractValidator<string>
{
    /// <summary>
    /// Adds a maximum length constraint to the string. Null values are not validated.
    /// </summary>
    /// <param name="maxLength">The maximum allowed length for the string.</param>
    /// <returns>This validator instance for method chaining.</returns>
    public StringValidator WithMaximumLength(int maxLength)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(str => str).MaximumLength(maxLength);
            }
        );
        return this;
    }

    /// <summary>
    /// Adds a minimum length constraint to the string. Null values are not validated.
    /// </summary>
    /// <param name="minLength">The minimum required length for the string.</param>
    /// <returns>This validator instance for method chaining.</returns>
    public StringValidator WithMinimumLength(int minLength)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(str => str).MinimumLength(minLength);
            }
        );
        return this;
    }

    /// <summary>
    /// Adds a regular expression pattern constraint to the string. Null values are not validated.
    /// </summary>
    /// <param name="pattern">The regular expression pattern the string must match.</param>
    /// <returns>This validator instance for method chaining.</returns>
    public StringValidator WithMatch(string pattern)
    {
        When(
            str => str != null,
            () =>
            {
                RuleFor(str => str).Matches(pattern);
            }
        );
        return this;
    }
}
