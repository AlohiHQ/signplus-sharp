namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class CreateTemplateRequestValidator : AbstractValidator<CreateTemplateRequest?>
{
    public CreateTemplateRequestValidator()
    {
        RuleFor(CreateTemplateRequest => CreateTemplateRequest.Name)
            .MinimumLength(2)
            .WithMessage("Minimum length for name is 2.")
            .MaximumLength(256)
            .WithMessage("Minimum length for name is 2.")
            .Matches(@"^[a-zA-Z0-9][a-zA-Z0-9 ]*[a-zA-Z0-9]$")
            .WithMessage(@"Pattern for name must match ^[a-zA-Z0-9][a-zA-Z0-9 ]*[a-zA-Z0-9]$.")
            .NotNull()
            .WithMessage("Field name is required and cannot be null.");
    }
}
