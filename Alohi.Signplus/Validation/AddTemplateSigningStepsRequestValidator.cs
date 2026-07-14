namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.AddTemplateSigningStepsRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class AddTemplateSigningStepsRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.AddTemplateSigningStepsRequest>
{
    public AddTemplateSigningStepsRequestValidator()
    {
        RuleFor(AddTemplateSigningStepsRequest => AddTemplateSigningStepsRequest.SigningSteps)
            .NotNull()
            .WithMessage("Field signing_steps is required and cannot be null.");
    }
}
