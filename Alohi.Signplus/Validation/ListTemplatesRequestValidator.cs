namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.ListTemplatesRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ListTemplatesRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.ListTemplatesRequest>
{
    public ListTemplatesRequestValidator()
    {
        RuleFor(ListTemplatesRequest => ListTemplatesRequest.Name)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Name cannot be null when provided.");
        RuleFor(ListTemplatesRequest => ListTemplatesRequest.Tags)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Tags cannot be null when provided.");
        RuleFor(ListTemplatesRequest => ListTemplatesRequest.Ids)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Ids cannot be null when provided.");
        RuleFor(ListTemplatesRequest => ListTemplatesRequest.First)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field First cannot be null when provided.");
        RuleFor(ListTemplatesRequest => ListTemplatesRequest.Last)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Last cannot be null when provided.");
        RuleFor(ListTemplatesRequest => ListTemplatesRequest.After)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field After cannot be null when provided.");
        RuleFor(ListTemplatesRequest => ListTemplatesRequest.Before)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Before cannot be null when provided.");
        RuleFor(ListTemplatesRequest => ListTemplatesRequest.OrderField)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field OrderField cannot be null when provided.");
        RuleFor(ListTemplatesRequest => ListTemplatesRequest.Ascending)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Ascending cannot be null when provided.");
    }
}
