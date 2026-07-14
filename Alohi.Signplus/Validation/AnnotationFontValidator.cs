namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.AnnotationFont model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class AnnotationFontValidator
    : AbstractValidator<global::Alohi.Signplus.Models.AnnotationFont>
{
    public AnnotationFontValidator()
    {
        RuleFor(AnnotationFont => AnnotationFont.Family)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Family cannot be null when provided.");
        RuleFor(AnnotationFont => AnnotationFont.Italic)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Italic cannot be null when provided.");
        RuleFor(AnnotationFont => AnnotationFont.Bold)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Bold cannot be null when provided.");
    }
}
