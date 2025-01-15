namespace Alohi.Signplus.Validation.Extensions;

using FluentValidation;
using FluentValidation.Results;

public static class ValidatorExtensions
{
    public static ValidationResult ValidateOptional<T>(this AbstractValidator<T> validator, T value)
    {
        if (value == null)
        {
            return new ValidationResult(
                new[]
                {
                    new ValidationFailure(nameof(value), "Value is required and cannot be null."),
                }
            );
        }
        return validator.Validate(value);
    }

    public static ValidationResult ValidateRequired<T>(this AbstractValidator<T> validator, T value)
    {
        if (value == null)
        {
            return new ValidationResult();
        }
        return validator.Validate(value);
    }
}
