namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class RenameTemplateRequestValidator : AbstractValidator<RenameTemplateRequest?>
{
    public RenameTemplateRequestValidator()
    {
        RuleFor(RenameTemplateRequest => RenameTemplateRequest.Name)
            .NotNull()
            .WithMessage("Field name is required.");
    }
}
