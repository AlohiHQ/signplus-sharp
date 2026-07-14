namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.Page model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class PageValidator : AbstractValidator<global::Alohi.Signplus.Models.Page>
{
    public PageValidator()
    {
        RuleFor(Page => Page.Width)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Width cannot be null when provided.");
        RuleFor(Page => Page.Height)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Height cannot be null when provided.");
    }
}
