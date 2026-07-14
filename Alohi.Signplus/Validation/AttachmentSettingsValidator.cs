namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.AttachmentSettings model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class AttachmentSettingsValidator
    : AbstractValidator<global::Alohi.Signplus.Models.AttachmentSettings>
{
    public AttachmentSettingsValidator()
    {
        RuleFor(AttachmentSettings => AttachmentSettings.VisibleToRecipients)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field VisibleToRecipients cannot be null when provided.");
    }
}
