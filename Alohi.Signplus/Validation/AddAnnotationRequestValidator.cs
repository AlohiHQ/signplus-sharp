namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.AddAnnotationRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class AddAnnotationRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.AddAnnotationRequest>
{
    public AddAnnotationRequestValidator()
    {
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.DocumentId)
            .NotNull()
            .WithMessage("Field document_id is required and cannot be null.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.Page)
            .NotNull()
            .WithMessage("Field page is required and cannot be null.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.X)
            .NotNull()
            .WithMessage("Field x is required and cannot be null.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.Y)
            .NotNull()
            .WithMessage("Field y is required and cannot be null.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.Width)
            .NotNull()
            .WithMessage("Field width is required and cannot be null.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.Height)
            .NotNull()
            .WithMessage("Field height is required and cannot be null.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.Type_)
            .NotNull()
            .WithMessage("Field type is required and cannot be null.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.RecipientId)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field RecipientId cannot be null when provided.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.Required)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Required cannot be null when provided.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.Signature)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Signature cannot be null when provided.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.Initials)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Initials cannot be null when provided.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.Text)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Text cannot be null when provided.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.Datetime)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Datetime cannot be null when provided.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.Checkbox)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Checkbox cannot be null when provided.");
    }
}
