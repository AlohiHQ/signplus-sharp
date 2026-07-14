namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.AnnotationDateTime model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class AnnotationDateTimeValidator
    : AbstractValidator<global::Alohi.Signplus.Models.AnnotationDateTime>
{
    public AnnotationDateTimeValidator()
    {
        RuleFor(AnnotationDateTime => AnnotationDateTime.Size)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Size cannot be null when provided.");
        RuleFor(AnnotationDateTime => AnnotationDateTime.Font)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Font cannot be null when provided.");
        RuleFor(AnnotationDateTime => AnnotationDateTime.Color)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Color cannot be null when provided.");
        RuleFor(AnnotationDateTime => AnnotationDateTime.AutoFill)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field AutoFill cannot be null when provided.");
        RuleFor(AnnotationDateTime => AnnotationDateTime.Timezone)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Timezone cannot be null when provided.");
        RuleFor(AnnotationDateTime => AnnotationDateTime.Timestamp)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Timestamp cannot be null when provided.");
        RuleFor(AnnotationDateTime => AnnotationDateTime.Format)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Format cannot be null when provided.");
    }
}
