namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.AttachmentPlaceholderFile model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class AttachmentPlaceholderFileValidator
    : AbstractValidator<global::Alohi.Signplus.Models.AttachmentPlaceholderFile>
{
    public AttachmentPlaceholderFileValidator()
    {
        RuleFor(AttachmentPlaceholderFile => AttachmentPlaceholderFile.Id)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Id cannot be null when provided.");
        RuleFor(AttachmentPlaceholderFile => AttachmentPlaceholderFile.Name)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Name cannot be null when provided.");
        RuleFor(AttachmentPlaceholderFile => AttachmentPlaceholderFile.Size)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Size cannot be null when provided.");
        RuleFor(AttachmentPlaceholderFile => AttachmentPlaceholderFile.Mimetype)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Mimetype cannot be null when provided.");
    }
}
