namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.ListTemplateDocumentAnnotationsResponse model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ListTemplateDocumentAnnotationsResponseValidator
    : AbstractValidator<global::Alohi.Signplus.Models.ListTemplateDocumentAnnotationsResponse>
{
    public ListTemplateDocumentAnnotationsResponseValidator()
    {
        RuleFor(ListTemplateDocumentAnnotationsResponse =>
                ListTemplateDocumentAnnotationsResponse.Annotations
            )
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Annotations cannot be null when provided.");
    }
}
