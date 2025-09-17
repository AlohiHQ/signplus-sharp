namespace Alohi.Signplus.Http.Exceptions;

using System;
using FluentValidation.Results;

public class ValidationException : Exception
{
    public List<ValidationFailure> ValidationFailure { get; }

    public ValidationException(List<ValidationFailure> validationFailure)
        : base(BuildValidationMessage(validationFailure))
    {
        ValidationFailure =
            validationFailure ?? throw new ArgumentNullException(nameof(validationFailure));
    }

    private static string BuildValidationMessage(List<ValidationFailure> validationFailure)
    {
        if (validationFailure == null || validationFailure.Count == 0)
        {
            return "Validation failed.";
        }

        var errorMessages = validationFailure
            .Select(failure => $"{failure.PropertyName}: {failure.ErrorMessage}")
            .ToArray();

        return $"Validation failed. Errors: {string.Join("; ", errorMessages)}";
    }
}
