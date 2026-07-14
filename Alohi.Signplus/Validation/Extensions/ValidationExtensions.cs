namespace Alohi.Signplus.Validation.Extensions;

using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// Extension methods for FluentValidation validators to handle optional vs required field validation semantics.
/// Provides consistent validation behavior for both reference types (classes) and value types (structs).
/// </summary>
public static class ValidatorExtensions
{
    /// <summary>
    /// Validates an optional reference type parameter using FluentValidation.
    /// </summary>
    /// <typeparam name="T">The reference type to validate.</typeparam>
    /// <param name="validator">The FluentValidation validator to use.</param>
    /// <param name="value">The value to validate.</param>
    /// <returns>ValidationResult indicating validation success or failure.</returns>
    public static ValidationResult ValidateOptional<T>(
        this AbstractValidator<T> validator,
        T? value
    )
        where T : class
    {
        if (value == null)
        {
            return new ValidationResult();
        }
        return validator.Validate(value);
    }

    /// <summary>
    /// Validates an optional value type parameter using FluentValidation.
    /// </summary>
    /// <typeparam name="T">The value type to validate.</typeparam>
    /// <param name="validator">The FluentValidation validator to use.</param>
    /// <param name="value">The nullable value to validate.</param>
    /// <returns>ValidationResult indicating validation success or failure.</returns>
    public static ValidationResult ValidateOptional<T>(
        this AbstractValidator<T> validator,
        T? value
    )
        where T : struct
    {
        if (value == null)
        {
            return new ValidationResult();
        }
        return validator.Validate(value.Value);
    }

    /// <summary>
    /// Validates a required reference type parameter using FluentValidation.
    /// </summary>
    /// <typeparam name="T">The reference type to validate.</typeparam>
    /// <param name="validator">The FluentValidation validator to use.</param>
    /// <param name="value">The value to validate.</param>
    /// <returns>ValidationResult indicating validation success or failure.</returns>
    public static ValidationResult ValidateRequired<T>(
        this AbstractValidator<T> validator,
        T? value
    )
        where T : class
    {
        if (value == null)
        {
            return new ValidationResult();
        }
        return validator.Validate(value);
    }

    /// <summary>
    /// Validates a required value type parameter using FluentValidation.
    /// </summary>
    /// <typeparam name="T">The value type to validate.</typeparam>
    /// <param name="validator">The FluentValidation validator to use.</param>
    /// <param name="value">The nullable value to validate.</param>
    /// <returns>ValidationResult indicating validation success or failure.</returns>
    public static ValidationResult ValidateRequired<T>(
        this AbstractValidator<T> validator,
        T? value
    )
        where T : struct
    {
        if (value == null)
        {
            return new ValidationResult();
        }
        return validator.Validate(value.Value);
    }

    /// <summary>
    /// Validates a required value type parameter using a validator defined with nullable types.
    /// Handles cases like NumberValidator : AbstractValidator&lt;long?&gt; where the validator itself accepts nullable types.
    /// </summary>
    /// <typeparam name="T">The value type to validate.</typeparam>
    /// <param name="validator">The FluentValidation validator for nullable types.</param>
    /// <param name="value">The nullable value to validate.</param>
    /// <returns>ValidationResult indicating validation success or failure.</returns>
    public static ValidationResult ValidateRequired<T>(
        this AbstractValidator<T?> validator,
        T? value
    )
        where T : struct
    {
        if (value == null)
        {
            return new ValidationResult();
        }
        return validator.Validate(value);
    }

    /// <summary>
    /// Validates an optional value type parameter using a validator defined with nullable types.
    /// Handles cases like NumberValidator : AbstractValidator&lt;long?&gt; where the validator itself accepts nullable types.
    /// </summary>
    /// <typeparam name="T">The value type to validate.</typeparam>
    /// <param name="validator">The FluentValidation validator for nullable types.</param>
    /// <param name="value">The nullable value to validate.</param>
    /// <returns>ValidationResult indicating validation success or failure.</returns>
    public static ValidationResult ValidateOptional<T>(
        this AbstractValidator<T?> validator,
        T? value
    )
        where T : struct
    {
        if (value == null)
        {
            return new ValidationResult();
        }
        return validator.Validate(value);
    }
}
