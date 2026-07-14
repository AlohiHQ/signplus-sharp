namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.ListWebhooksResponse model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ListWebhooksResponseValidator
    : AbstractValidator<global::Alohi.Signplus.Models.ListWebhooksResponse>
{
    public ListWebhooksResponseValidator()
    {
        RuleFor(ListWebhooksResponse => ListWebhooksResponse.Webhooks)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Webhooks cannot be null when provided.");
    }
}
