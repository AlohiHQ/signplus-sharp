namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class SetTemplateCommentRequestValidator : AbstractValidator<SetTemplateCommentRequest?>
{
    public SetTemplateCommentRequestValidator()
    {
        RuleFor(SetTemplateCommentRequest => SetTemplateCommentRequest.Comment)
            .NotNull()
            .WithMessage("Field comment is required and cannot be null.");
    }
}
