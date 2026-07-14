namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.AddEnvelopeSigningStepsRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class AddEnvelopeSigningStepsRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.AddEnvelopeSigningStepsRequest>
{
    public AddEnvelopeSigningStepsRequestValidator()
    {
        RuleFor(AddEnvelopeSigningStepsRequest => AddEnvelopeSigningStepsRequest.SigningSteps)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field SigningSteps cannot be null when provided.");
    }
}
