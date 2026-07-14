namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.SetEnvelopeExpirationRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class SetEnvelopeExpirationRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.SetEnvelopeExpirationRequest>
{
    public SetEnvelopeExpirationRequestValidator()
    {
        RuleFor(SetEnvelopeExpirationRequest => SetEnvelopeExpirationRequest.ExpiresAt)
            .NotNull()
            .WithMessage("Field expires_at is required and cannot be null.");
    }
}
