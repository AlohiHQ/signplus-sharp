namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.AttachmentPlaceholder model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class AttachmentPlaceholderValidator
    : AbstractValidator<global::Alohi.Signplus.Models.AttachmentPlaceholder>
{
    public AttachmentPlaceholderValidator()
    {
        RuleFor(AttachmentPlaceholder => AttachmentPlaceholder.RecipientId)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field RecipientId cannot be null when provided.");
        RuleFor(AttachmentPlaceholder => AttachmentPlaceholder.Id)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Id cannot be null when provided.");
        RuleFor(AttachmentPlaceholder => AttachmentPlaceholder.Name)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Name cannot be null when provided.");
        RuleFor(AttachmentPlaceholder => AttachmentPlaceholder.Hint)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Hint cannot be null when provided.");
        RuleFor(AttachmentPlaceholder => AttachmentPlaceholder.Required)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Required cannot be null when provided.");
        RuleFor(AttachmentPlaceholder => AttachmentPlaceholder.Multiple)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Multiple cannot be null when provided.");
        RuleFor(AttachmentPlaceholder => AttachmentPlaceholder.Files)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Files cannot be null when provided.");
    }
}
