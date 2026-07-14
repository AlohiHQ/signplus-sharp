namespace Alohi.Signplus.Validation;

using FluentValidation;

/// <summary>
/// Fluent validator for nullable integer (long) values with support for range and multiple-of constraints.
/// Provides chainable methods for adding validation rules to numeric properties.
/// </summary>
public class NumberValidator : AbstractValidator<long?>
{
    /// <summary>
    /// Adds an exclusive minimum constraint (value must be strictly greater than min). Null values are not validated.
    /// </summary>
    /// <param name="min">The exclusive minimum value.</param>
    /// <returns>This validator instance for method chaining.</returns>
    public NumberValidator WithGreaterThan(long min)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(num => num).Must(num => num > min);
            }
        );
        return this;
    }

    /// <summary>
    /// Adds an inclusive minimum constraint (value must be greater than or equal to min). Null values are not validated.
    /// </summary>
    /// <param name="min">The inclusive minimum value.</param>
    /// <returns>This validator instance for method chaining.</returns>
    public NumberValidator WithGreaterThanOrEqualTo(long min)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(num => num).GreaterThanOrEqualTo(min);
            }
        );
        return this;
    }

    /// <summary>
    /// Adds an exclusive maximum constraint (value must be strictly less than max). Null values are not validated.
    /// </summary>
    /// <param name="max">The exclusive maximum value.</param>
    /// <returns>This validator instance for method chaining.</returns>
    public NumberValidator WithLessThan(long max)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(num => num).Must(num => num < max);
            }
        );
        return this;
    }

    /// <summary>
    /// Adds an inclusive maximum constraint (value must be less than or equal to max). Null values are not validated.
    /// </summary>
    /// <param name="max">The inclusive maximum value.</param>
    /// <returns>This validator instance for method chaining.</returns>
    public NumberValidator WithLessThanOrEqualTo(long max)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(num => num).LessThanOrEqualTo(max);
            }
        );
        return this;
    }

    /// <summary>
    /// Adds a multipleOf constraint (value must be evenly divisible by multipleOf). Null values are not validated.
    /// </summary>
    /// <param name="multipleOf">The divisor that the value must be a multiple of.</param>
    /// <returns>This validator instance for method chaining.</returns>
    public NumberValidator WithMultipleOf(long multipleOf)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(num => num).Must(value => value % multipleOf == 0);
            }
        );
        return this;
    }
}
