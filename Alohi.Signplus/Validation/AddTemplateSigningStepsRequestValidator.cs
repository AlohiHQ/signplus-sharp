namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class AddTemplateSigningStepsRequestValidator
    : AbstractValidator<AddTemplateSigningStepsRequest?>
{
    public AddTemplateSigningStepsRequestValidator()
    {
        RuleFor(AddTemplateSigningStepsRequest => AddTemplateSigningStepsRequest.SigningSteps)
            .NotNull()
            .WithMessage("Field signing_steps is required.");
    }
}
