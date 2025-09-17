namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class CreateWebhookRequestValidator : AbstractValidator<CreateWebhookRequest?>
{
    public CreateWebhookRequestValidator()
    {
        RuleFor(CreateWebhookRequest => CreateWebhookRequest.Event_)
            .NotNull()
            .WithMessage("Field event is required and cannot be null.");
        RuleFor(CreateWebhookRequest => CreateWebhookRequest.Target)
            .NotNull()
            .WithMessage("Field target is required and cannot be null.");
    }
}
