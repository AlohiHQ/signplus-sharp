namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class RecipientVerificationTypeValidator : AbstractValidator<RecipientVerificationType?>
{
    public RecipientVerificationTypeValidator() { }
}
