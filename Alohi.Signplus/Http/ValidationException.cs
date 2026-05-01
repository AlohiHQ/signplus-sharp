namespace Alohi.Signplus.Http.Exceptions;

using System;
using FluentValidation.Results;

/// <summary>
/// Exception thrown when request or response data fails validation.
/// Contains detailed information about all validation failures including property names and error messages.
/// </summary>
public class ValidationException : Exception
{
    /// <summary>
    /// Gets the list of validation failures that triggered this exception.
    /// Each failure contains the property name and specific error message.
    /// </summary>
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
