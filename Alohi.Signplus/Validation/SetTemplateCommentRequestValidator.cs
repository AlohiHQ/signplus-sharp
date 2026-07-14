namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.SetTemplateCommentRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class SetTemplateCommentRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.SetTemplateCommentRequest>
{
    public SetTemplateCommentRequestValidator()
    {
        RuleFor(SetTemplateCommentRequest => SetTemplateCommentRequest.Comment)
            .NotNull()
            .WithMessage("Field comment is required and cannot be null.");
    }
}
