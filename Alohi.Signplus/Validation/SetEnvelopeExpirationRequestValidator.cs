namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class SetEnvelopeExpirationRequestValidator
    : AbstractValidator<SetEnvelopeExpirationRequest?>
{
    public SetEnvelopeExpirationRequestValidator()
    {
        RuleFor(SetEnvelopeExpirationRequest => SetEnvelopeExpirationRequest.ExpiresAt)
            .NotNull()
            .WithMessage("Field expires_at is required and cannot be null.");
    }
}
