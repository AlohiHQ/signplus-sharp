namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.SetEnvelopeAttachmentsPlaceholdersRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class SetEnvelopeAttachmentsPlaceholdersRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.SetEnvelopeAttachmentsPlaceholdersRequest>
{
    public SetEnvelopeAttachmentsPlaceholdersRequestValidator()
    {
        RuleFor(SetEnvelopeAttachmentsPlaceholdersRequest =>
                SetEnvelopeAttachmentsPlaceholdersRequest.Placeholders
            )
            .NotNull()
            .WithMessage("Field placeholders is required and cannot be null.");
    }
}
