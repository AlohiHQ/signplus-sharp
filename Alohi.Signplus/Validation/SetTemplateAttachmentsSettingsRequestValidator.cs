namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for SetTemplateAttachmentsSettingsRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class SetTemplateAttachmentsSettingsRequestValidator
    : AbstractValidator<SetTemplateAttachmentsSettingsRequest>
{
    public SetTemplateAttachmentsSettingsRequestValidator() { }
}
