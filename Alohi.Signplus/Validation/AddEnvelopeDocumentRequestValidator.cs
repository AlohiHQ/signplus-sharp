namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.AddEnvelopeDocumentRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class AddEnvelopeDocumentRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.AddEnvelopeDocumentRequest>
{
    public AddEnvelopeDocumentRequestValidator()
    {
        RuleFor(AddEnvelopeDocumentRequest => AddEnvelopeDocumentRequest.File)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field File cannot be null when provided.");
    }
}
