namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class SetEnvelopeAttachmentsPlaceholdersRequestValidator
    : AbstractValidator<SetEnvelopeAttachmentsPlaceholdersRequest?>
{
    public SetEnvelopeAttachmentsPlaceholdersRequestValidator()
    {
        RuleFor(SetEnvelopeAttachmentsPlaceholdersRequest =>
                SetEnvelopeAttachmentsPlaceholdersRequest.Placeholders
            )
            .NotNull()
            .WithMessage("Field placeholders is required and cannot be null.");
    }
}
