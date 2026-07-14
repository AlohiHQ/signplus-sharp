namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.SetEnvelopeAttachmentsSettingsRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class SetEnvelopeAttachmentsSettingsRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.SetEnvelopeAttachmentsSettingsRequest>
{
    public SetEnvelopeAttachmentsSettingsRequestValidator()
    {
        RuleFor(SetEnvelopeAttachmentsSettingsRequest =>
                SetEnvelopeAttachmentsSettingsRequest.Settings
            )
            .Custom(
                (attachmentSettings, context) =>
                {
                    if (attachmentSettings != null)
                    {
                        var validator = new AttachmentSettingsValidator();
                        var result = validator.Validate(attachmentSettings);
                        if (!result.IsValid)
                        {
                            foreach (var failure in result.Errors)
                            {
                                context.AddFailure(failure.PropertyName, failure.ErrorMessage);
                            }
                        }
                    }
                }
            )
            .NotNull()
            .WithMessage("Field settings is required and cannot be null.");
    }
}
