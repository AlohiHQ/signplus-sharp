namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.ListWebhooksRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ListWebhooksRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.ListWebhooksRequest>
{
    public ListWebhooksRequestValidator()
    {
        RuleFor(ListWebhooksRequest => ListWebhooksRequest.WebhookId)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field WebhookId cannot be null when provided.");
        RuleFor(ListWebhooksRequest => ListWebhooksRequest.Event_)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Event_ cannot be null when provided.");
    }
}
