namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class RecipientValidator : AbstractValidator<Recipient?>
{
    public RecipientValidator()
    {
        RuleFor(Recipient => Recipient.Name)
            .NotNull()
            .WithMessage("Field name is required and cannot be null.");
        RuleFor(Recipient => Recipient.Email)
            .NotNull()
            .WithMessage("Field email is required and cannot be null.");
        RuleFor(Recipient => Recipient.Role)
            .NotNull()
            .WithMessage("Field role is required and cannot be null.");
    }
}
