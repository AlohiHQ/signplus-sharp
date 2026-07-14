namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.Template model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class TemplateValidator : AbstractValidator<global::Alohi.Signplus.Models.Template>
{
    public TemplateValidator()
    {
        RuleFor(Template => Template.Id)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Id cannot be null when provided.");
        RuleFor(Template => Template.Name)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Name cannot be null when provided.");
        RuleFor(Template => Template.Comment)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Comment cannot be null when provided.");
        RuleFor(Template => Template.Pages)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Pages cannot be null when provided.");
        RuleFor(Template => Template.LegalityLevel)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field LegalityLevel cannot be null when provided.");
        RuleFor(Template => Template.CreatedAt)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field CreatedAt cannot be null when provided.");
        RuleFor(Template => Template.UpdatedAt)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field UpdatedAt cannot be null when provided.");
        RuleFor(Template => Template.ExpirationDelay)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field ExpirationDelay cannot be null when provided.");
        RuleFor(Template => Template.NumRecipients)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field NumRecipients cannot be null when provided.");
        RuleFor(Template => Template.SigningSteps)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field SigningSteps cannot be null when provided.");
        RuleFor(Template => Template.Documents)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Documents cannot be null when provided.");
        RuleFor(Template => Template.Notification)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Notification cannot be null when provided.");
        RuleFor(Template => Template.DynamicFields)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field DynamicFields cannot be null when provided.");
        RuleFor(Template => Template.Attachments)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Attachments cannot be null when provided.");
    }
}
