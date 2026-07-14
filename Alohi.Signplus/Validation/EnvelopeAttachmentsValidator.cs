namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.EnvelopeAttachments model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class EnvelopeAttachmentsValidator
    : AbstractValidator<global::Alohi.Signplus.Models.EnvelopeAttachments>
{
    public EnvelopeAttachmentsValidator()
    {
        RuleFor(EnvelopeAttachments => EnvelopeAttachments.Settings)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Settings cannot be null when provided.");
        RuleFor(EnvelopeAttachments => EnvelopeAttachments.Recipients)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Recipients cannot be null when provided.");
    }
}
