namespace Alohi.Signplus.Validation;

using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// Fluent validator for nullable floating-point (double) values with support for range and multiple-of constraints.
/// Provides chainable methods for adding validation rules to numeric properties.
/// </summary>
public class FloatValidator : AbstractValidator<double?>
{
    private readonly string _name;

    public FloatValidator(string name)
    {
        _name = name;
    }

    /// <summary>
    /// Adds an exclusive minimum constraint (value must be strictly greater than min). Null values are not validated.
    /// </summary>
    /// <param name="min">The exclusive minimum value.</param>
    /// <returns>This validator instance for method chaining.</returns>
    public FloatValidator WithGreaterThan(double min)
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
    public FloatValidator WithGreaterThanOrEqualTo(double min)
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
    public FloatValidator WithLessThan(double max)
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
    public FloatValidator WithLessThanOrEqualTo(double max)
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
    public FloatValidator WithMultipleOf(double multipleOf)
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
