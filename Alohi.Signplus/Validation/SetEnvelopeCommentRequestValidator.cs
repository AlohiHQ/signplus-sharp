namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class SetEnvelopeCommentRequestValidator : AbstractValidator<SetEnvelopeCommentRequest?>
{
    public SetEnvelopeCommentRequestValidator()
    {
        RuleFor(SetEnvelopeCommentRequest => SetEnvelopeCommentRequest.Comment)
            .NotNull()
            .WithMessage("Field comment is required and cannot be null.");
    }
}
