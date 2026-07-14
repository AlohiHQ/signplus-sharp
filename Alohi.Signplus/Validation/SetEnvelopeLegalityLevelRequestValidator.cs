namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.SetEnvelopeLegalityLevelRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class SetEnvelopeLegalityLevelRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.SetEnvelopeLegalityLevelRequest>
{
    public SetEnvelopeLegalityLevelRequestValidator()
    {
        RuleFor(SetEnvelopeLegalityLevelRequest => SetEnvelopeLegalityLevelRequest.LegalityLevel)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field LegalityLevel cannot be null when provided.");
    }
}
