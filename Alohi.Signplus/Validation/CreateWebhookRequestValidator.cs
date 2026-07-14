namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.CreateWebhookRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class CreateWebhookRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.CreateWebhookRequest>
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
