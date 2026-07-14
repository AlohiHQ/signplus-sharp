namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.TemplateSigningStep model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class TemplateSigningStepValidator
    : AbstractValidator<global::Alohi.Signplus.Models.TemplateSigningStep>
{
    public TemplateSigningStepValidator()
    {
        RuleFor(TemplateSigningStep => TemplateSigningStep.Recipients)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Recipients cannot be null when provided.");
    }
}
