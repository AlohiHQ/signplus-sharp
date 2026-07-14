namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.AnnotationCheckbox model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class AnnotationCheckboxValidator
    : AbstractValidator<global::Alohi.Signplus.Models.AnnotationCheckbox>
{
    public AnnotationCheckboxValidator()
    {
        RuleFor(AnnotationCheckbox => AnnotationCheckbox.Checked_)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Checked_ cannot be null when provided.");
        RuleFor(AnnotationCheckbox => AnnotationCheckbox.Style)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Style cannot be null when provided.");
    }
}
