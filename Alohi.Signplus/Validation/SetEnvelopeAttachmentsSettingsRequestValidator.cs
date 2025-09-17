namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class SetEnvelopeAttachmentsSettingsRequestValidator
    : AbstractValidator<SetEnvelopeAttachmentsSettingsRequest?>
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
