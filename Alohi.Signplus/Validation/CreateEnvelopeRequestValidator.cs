namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class CreateEnvelopeRequestValidator : AbstractValidator<CreateEnvelopeRequest?>
{
    public CreateEnvelopeRequestValidator()
    {
        RuleFor(CreateEnvelopeRequest => CreateEnvelopeRequest.Name)
            .MinimumLength(2)
            .WithMessage("Minimum length for name is 2.")
            .MaximumLength(256)
            .WithMessage("Minimum length for name is 2.")
            .Matches(@"^[a-zA-Z0-9][a-zA-Z0-9 ]*[a-zA-Z0-9]$")
            .WithMessage(@"Pattern for name must match ^[a-zA-Z0-9][a-zA-Z0-9 ]*[a-zA-Z0-9]$.")
            .NotNull()
            .WithMessage("Field name is required and cannot be null.");
        RuleFor(CreateEnvelopeRequest => CreateEnvelopeRequest.LegalityLevel)
            .NotNull()
            .WithMessage("Field legality_level is required and cannot be null.");
    }
}
