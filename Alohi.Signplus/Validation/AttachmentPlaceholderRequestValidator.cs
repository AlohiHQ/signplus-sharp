namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class AttachmentPlaceholderRequestValidator
    : AbstractValidator<AttachmentPlaceholderRequest?>
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
    }
}
