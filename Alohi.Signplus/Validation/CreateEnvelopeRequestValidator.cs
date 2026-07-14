namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.CreateEnvelopeRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class CreateEnvelopeRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.CreateEnvelopeRequest>
{
    public CreateEnvelopeRequestValidator()
    {
        RuleFor(CreateEnvelopeRequest => CreateEnvelopeRequest.Name)
            .MinimumLength(2)
            .WithMessage("Minimum length for name is 2.")
            .MaximumLength(256)
            .WithMessage("Minimum length for name is 2.")
            .Matches(@"^[a-zA-Z0-9][a-zA-Z0-9 ]*[a-zA-Z0-9]$")
            .WithMessage(@"Pattern for name must match ^[a-zA-Z0-9][a-zA-Z0-9 ]*[a-zA-Z0-9]$.")
            .NotNull()
            .WithMessage("Field name is required and cannot be null.");
        RuleFor(CreateEnvelopeRequest => CreateEnvelopeRequest.LegalityLevel)
            .NotNull()
            .WithMessage("Field legality_level is required and cannot be null.");
        RuleFor(CreateEnvelopeRequest => CreateEnvelopeRequest.ExpiresAt)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field ExpiresAt cannot be null when provided.");
        RuleFor(CreateEnvelopeRequest => CreateEnvelopeRequest.Comment)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Comment cannot be null when provided.");
        RuleFor(CreateEnvelopeRequest => CreateEnvelopeRequest.Sandbox)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Sandbox cannot be null when provided.");
    }
}
