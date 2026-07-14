namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.Recipient model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class RecipientValidator : AbstractValidator<global::Alohi.Signplus.Models.Recipient>
{
    public RecipientValidator()
    {
        RuleFor(Recipient => Recipient.Name)
            .NotNull()
            .WithMessage("Field name is required and cannot be null.");
        RuleFor(Recipient => Recipient.Email)
            .NotNull()
            .WithMessage("Field email is required and cannot be null.");
        RuleFor(Recipient => Recipient.Role)
            .NotNull()
            .WithMessage("Field role is required and cannot be null.");
        RuleFor(Recipient => Recipient.Id)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Id cannot be null when provided.");
        RuleFor(Recipient => Recipient.Uid)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Uid cannot be null when provided.");
        RuleFor(Recipient => Recipient.Verification)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Verification cannot be null when provided.");
    }
}
