namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.ListTemplateAnnotationsResponse model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ListTemplateAnnotationsResponseValidator
    : AbstractValidator<global::Alohi.Signplus.Models.ListTemplateAnnotationsResponse>
{
    public ListTemplateAnnotationsResponseValidator()
    {
        RuleFor(ListTemplateAnnotationsResponse => ListTemplateAnnotationsResponse.Annotations)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Annotations cannot be null when provided.");
    }
}
