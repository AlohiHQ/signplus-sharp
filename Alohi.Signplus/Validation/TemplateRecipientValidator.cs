namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.TemplateRecipient model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class TemplateRecipientValidator
    : AbstractValidator<global::Alohi.Signplus.Models.TemplateRecipient>
{
    public TemplateRecipientValidator()
    {
        RuleFor(TemplateRecipient => TemplateRecipient.Id)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Id cannot be null when provided.");
        RuleFor(TemplateRecipient => TemplateRecipient.Uid)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Uid cannot be null when provided.");
        RuleFor(TemplateRecipient => TemplateRecipient.Name)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Name cannot be null when provided.");
        RuleFor(TemplateRecipient => TemplateRecipient.Email)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Email cannot be null when provided.");
        RuleFor(TemplateRecipient => TemplateRecipient.Role)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Role cannot be null when provided.");
    }
}
