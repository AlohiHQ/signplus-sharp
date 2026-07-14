namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.Envelope model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class EnvelopeValidator : AbstractValidator<global::Alohi.Signplus.Models.Envelope>
{
    public EnvelopeValidator()
    {
        RuleFor(Envelope => Envelope.Id)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Id cannot be null when provided.");
        RuleFor(Envelope => Envelope.Name)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Name cannot be null when provided.");
        RuleFor(Envelope => Envelope.Comment)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Comment cannot be null when provided.");
        RuleFor(Envelope => Envelope.Pages)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Pages cannot be null when provided.");
        RuleFor(Envelope => Envelope.FlowType)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field FlowType cannot be null when provided.");
        RuleFor(Envelope => Envelope.LegalityLevel)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field LegalityLevel cannot be null when provided.");
        RuleFor(Envelope => Envelope.Status)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Status cannot be null when provided.");
        RuleFor(Envelope => Envelope.CreatedAt)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field CreatedAt cannot be null when provided.");
        RuleFor(Envelope => Envelope.UpdatedAt)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field UpdatedAt cannot be null when provided.");
        RuleFor(Envelope => Envelope.ExpiresAt)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field ExpiresAt cannot be null when provided.");
        RuleFor(Envelope => Envelope.NumRecipients)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field NumRecipients cannot be null when provided.");
        RuleFor(Envelope => Envelope.IsDuplicable)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field IsDuplicable cannot be null when provided.");
        RuleFor(Envelope => Envelope.SigningSteps)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field SigningSteps cannot be null when provided.");
        RuleFor(Envelope => Envelope.Documents)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Documents cannot be null when provided.");
        RuleFor(Envelope => Envelope.Notification)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Notification cannot be null when provided.");
        RuleFor(Envelope => Envelope.Attachments)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Attachments cannot be null when provided.");
    }
}
