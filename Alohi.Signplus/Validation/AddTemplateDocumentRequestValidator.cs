namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.AddTemplateDocumentRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class AddTemplateDocumentRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.AddTemplateDocumentRequest>
{
    public AddTemplateDocumentRequestValidator()
    {
        RuleFor(AddTemplateDocumentRequest => AddTemplateDocumentRequest.File)
            .NotNull()
            .WithMessage("Field file is required and cannot be null.");
    }
}
