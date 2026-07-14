namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.EnvelopeNotification model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class EnvelopeNotificationValidator
    : AbstractValidator<global::Alohi.Signplus.Models.EnvelopeNotification>
{
    public EnvelopeNotificationValidator()
    {
        RuleFor(EnvelopeNotification => EnvelopeNotification.Subject)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Subject cannot be null when provided.");
        RuleFor(EnvelopeNotification => EnvelopeNotification.Message)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Message cannot be null when provided.");
        RuleFor(EnvelopeNotification => EnvelopeNotification.ReminderInterval)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field ReminderInterval cannot be null when provided.");
    }
}
