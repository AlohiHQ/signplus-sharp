namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.AttachmentPlaceholderRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class AttachmentPlaceholderRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.AttachmentPlaceholderRequest>
{
    public AttachmentPlaceholderRequestValidator()
    {
        RuleFor(AttachmentPlaceholderRequest => AttachmentPlaceholderRequest.RecipientId)
            .NotNull()
            .WithMessage("Field recipient_id is required and cannot be null.");
        RuleFor(AttachmentPlaceholderRequest => AttachmentPlaceholderRequest.Name)
            .NotNull()
            .WithMessage("Field name is required and cannot be null.");
        RuleFor(AttachmentPlaceholderRequest => AttachmentPlaceholderRequest.Required)
            .NotNull()
            .WithMessage("Field required is required and cannot be null.");
        RuleFor(AttachmentPlaceholderRequest => AttachmentPlaceholderRequest.Multiple)
            .NotNull()
            .WithMessage("Field multiple is required and cannot be null.");
        RuleFor(AttachmentPlaceholderRequest => AttachmentPlaceholderRequest.Id)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Id cannot be null when provided.");
        RuleFor(AttachmentPlaceholderRequest => AttachmentPlaceholderRequest.Hint)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Hint cannot be null when provided.");
    }
}
