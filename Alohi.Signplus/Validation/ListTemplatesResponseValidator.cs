namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.ListTemplatesResponse model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ListTemplatesResponseValidator
    : AbstractValidator<global::Alohi.Signplus.Models.ListTemplatesResponse>
{
    public ListTemplatesResponseValidator()
    {
        RuleFor(ListTemplatesResponse => ListTemplatesResponse.HasNextPage)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field HasNextPage cannot be null when provided.");
        RuleFor(ListTemplatesResponse => ListTemplatesResponse.HasPreviousPage)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field HasPreviousPage cannot be null when provided.");
        RuleFor(ListTemplatesResponse => ListTemplatesResponse.Templates)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Templates cannot be null when provided.");
    }
}
