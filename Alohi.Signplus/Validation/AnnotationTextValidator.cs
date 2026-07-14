namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.AnnotationText model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class AnnotationTextValidator
    : AbstractValidator<global::Alohi.Signplus.Models.AnnotationText>
{
    public AnnotationTextValidator()
    {
        RuleFor(AnnotationText => AnnotationText.Size)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Size cannot be null when provided.");
        RuleFor(AnnotationText => AnnotationText.Color)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Color cannot be null when provided.");
        RuleFor(AnnotationText => AnnotationText.Value)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Value cannot be null when provided.");
        RuleFor(AnnotationText => AnnotationText.Tooltip)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Tooltip cannot be null when provided.");
        RuleFor(AnnotationText => AnnotationText.DynamicFieldName)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field DynamicFieldName cannot be null when provided.");
        RuleFor(AnnotationText => AnnotationText.Font)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Font cannot be null when provided.");
    }
}
