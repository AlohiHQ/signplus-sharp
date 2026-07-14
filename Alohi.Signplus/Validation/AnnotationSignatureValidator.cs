namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.AnnotationSignature model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class AnnotationSignatureValidator
    : AbstractValidator<global::Alohi.Signplus.Models.AnnotationSignature>
{
    public AnnotationSignatureValidator()
    {
        RuleFor(AnnotationSignature => AnnotationSignature.Id)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Id cannot be null when provided.");
    }
}
