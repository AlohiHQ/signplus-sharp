namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.RenameTemplateRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class RenameTemplateRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.RenameTemplateRequest>
{
    public RenameTemplateRequestValidator()
    {
        RuleFor(RenameTemplateRequest => RenameTemplateRequest.Name)
            .NotNull()
            .WithMessage("Field name is required and cannot be null.");
    }
}
