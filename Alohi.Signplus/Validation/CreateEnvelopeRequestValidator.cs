namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class CreateEnvelopeRequestValidator : AbstractValidator<CreateEnvelopeRequest?>
{
    public CreateEnvelopeRequestValidator()
    {
        RuleFor(CreateEnvelopeRequest => CreateEnvelopeRequest.Name)
            .NotNull()
            .WithMessage("Field name is required.");
        RuleFor(CreateEnvelopeRequest => CreateEnvelopeRequest.LegalityLevel)
            .NotNull()
            .WithMessage("Field legality_level is required.");
    }
}
