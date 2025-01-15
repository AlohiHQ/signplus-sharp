namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class CreateTemplateRequestValidator : AbstractValidator<CreateTemplateRequest?>
{
    public CreateTemplateRequestValidator()
    {
        RuleFor(CreateTemplateRequest => CreateTemplateRequest.Name)
            .NotNull()
            .WithMessage("Field name is required.");
    }
}
