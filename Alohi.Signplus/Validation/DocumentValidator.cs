namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.Document model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class DocumentValidator : AbstractValidator<global::Alohi.Signplus.Models.Document>
{
    public DocumentValidator()
    {
        RuleFor(Document => Document.Id)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Id cannot be null when provided.");
        RuleFor(Document => Document.Name)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Name cannot be null when provided.");
        RuleFor(Document => Document.Filename)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Filename cannot be null when provided.");
        RuleFor(Document => Document.PageCount)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field PageCount cannot be null when provided.");
        RuleFor(Document => Document.Pages)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Pages cannot be null when provided.");
    }
}
