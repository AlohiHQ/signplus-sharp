namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.Annotation model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class AnnotationValidator : AbstractValidator<global::Alohi.Signplus.Models.Annotation>
{
    public AnnotationValidator()
    {
        RuleFor(Annotation => Annotation.Id)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Id cannot be null when provided.");
        RuleFor(Annotation => Annotation.RecipientId)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field RecipientId cannot be null when provided.");
        RuleFor(Annotation => Annotation.DocumentId)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field DocumentId cannot be null when provided.");
        RuleFor(Annotation => Annotation.Page)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Page cannot be null when provided.");
        RuleFor(Annotation => Annotation.X)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field X cannot be null when provided.");
        RuleFor(Annotation => Annotation.Y)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Y cannot be null when provided.");
        RuleFor(Annotation => Annotation.Width)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Width cannot be null when provided.");
        RuleFor(Annotation => Annotation.Height)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Height cannot be null when provided.");
        RuleFor(Annotation => Annotation.Required)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Required cannot be null when provided.");
        RuleFor(Annotation => Annotation.Type_)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Type_ cannot be null when provided.");
        RuleFor(Annotation => Annotation.Signature)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Signature cannot be null when provided.");
        RuleFor(Annotation => Annotation.Initials)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Initials cannot be null when provided.");
        RuleFor(Annotation => Annotation.Text)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Text cannot be null when provided.");
        RuleFor(Annotation => Annotation.Datetime)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Datetime cannot be null when provided.");
        RuleFor(Annotation => Annotation.Checkbox)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Checkbox cannot be null when provided.");
    }
}
