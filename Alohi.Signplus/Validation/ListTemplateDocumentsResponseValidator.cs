namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.ListTemplateDocumentsResponse model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ListTemplateDocumentsResponseValidator
    : AbstractValidator<global::Alohi.Signplus.Models.ListTemplateDocumentsResponse>
{
    public ListTemplateDocumentsResponseValidator()
    {
        RuleFor(ListTemplateDocumentsResponse => ListTemplateDocumentsResponse.Documents)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Documents cannot be null when provided.");
    }
}
