namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.CreateEnvelopeFromTemplateRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class CreateEnvelopeFromTemplateRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.CreateEnvelopeFromTemplateRequest>
{
    public CreateEnvelopeFromTemplateRequestValidator()
    {
        RuleFor(CreateEnvelopeFromTemplateRequest => CreateEnvelopeFromTemplateRequest.Name)
            .MinimumLength(2)
            .WithMessage("Minimum length for name is 2.")
            .MaximumLength(256)
            .WithMessage("Minimum length for name is 2.")
            .Matches(@"^[a-zA-Z0-9][a-zA-Z0-9 ]*[a-zA-Z0-9]$")
            .WithMessage(@"Pattern for name must match ^[a-zA-Z0-9][a-zA-Z0-9 ]*[a-zA-Z0-9]$.")
            .NotNull()
            .WithMessage("Field name is required and cannot be null.");
        RuleFor(CreateEnvelopeFromTemplateRequest => CreateEnvelopeFromTemplateRequest.Comment)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Comment cannot be null when provided.");
        RuleFor(CreateEnvelopeFromTemplateRequest => CreateEnvelopeFromTemplateRequest.Sandbox)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Sandbox cannot be null when provided.");
    }
}
