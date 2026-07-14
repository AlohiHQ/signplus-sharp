namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.ListEnvelopesResponse model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ListEnvelopesResponseValidator
    : AbstractValidator<global::Alohi.Signplus.Models.ListEnvelopesResponse>
{
    public ListEnvelopesResponseValidator()
    {
        RuleFor(ListEnvelopesResponse => ListEnvelopesResponse.HasNextPage)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field HasNextPage cannot be null when provided.");
        RuleFor(ListEnvelopesResponse => ListEnvelopesResponse.HasPreviousPage)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field HasPreviousPage cannot be null when provided.");
        RuleFor(ListEnvelopesResponse => ListEnvelopesResponse.Envelopes)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Envelopes cannot be null when provided.");
    }
}
