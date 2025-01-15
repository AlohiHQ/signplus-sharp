namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class CreateEnvelopeFromTemplateRequestValidator
    : AbstractValidator<CreateEnvelopeFromTemplateRequest?>
{
    public CreateEnvelopeFromTemplateRequestValidator()
    {
        RuleFor(CreateEnvelopeFromTemplateRequest => CreateEnvelopeFromTemplateRequest.Name)
            .NotNull()
            .WithMessage("Field name is required.");
    }
}
