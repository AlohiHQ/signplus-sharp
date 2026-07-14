namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.AnnotationType model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class AnnotationTypeValidator
    : AbstractValidator<global::Alohi.Signplus.Models.AnnotationType>
{
    public AnnotationTypeValidator() { }
}
