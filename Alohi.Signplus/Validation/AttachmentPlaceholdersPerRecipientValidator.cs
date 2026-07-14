namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.AttachmentPlaceholdersPerRecipient model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class AttachmentPlaceholdersPerRecipientValidator
    : AbstractValidator<global::Alohi.Signplus.Models.AttachmentPlaceholdersPerRecipient>
{
    public AttachmentPlaceholdersPerRecipientValidator()
    {
        RuleFor(AttachmentPlaceholdersPerRecipient =>
                AttachmentPlaceholdersPerRecipient.RecipientId
            )
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field RecipientId cannot be null when provided.");
        RuleFor(AttachmentPlaceholdersPerRecipient =>
                AttachmentPlaceholdersPerRecipient.RecipientName
            )
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field RecipientName cannot be null when provided.");
        RuleFor(AttachmentPlaceholdersPerRecipient =>
                AttachmentPlaceholdersPerRecipient.Placeholders
            )
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Placeholders cannot be null when provided.");
    }
}
