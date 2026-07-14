namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.RenameEnvelopeRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class RenameEnvelopeRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.RenameEnvelopeRequest>
{
    public RenameEnvelopeRequestValidator()
    {
        RuleFor(RenameEnvelopeRequest => RenameEnvelopeRequest.Name)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Name cannot be null when provided.");
    }
}
