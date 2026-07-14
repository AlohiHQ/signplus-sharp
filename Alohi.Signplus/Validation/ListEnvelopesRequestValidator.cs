namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

/// <summary>
/// FluentValidation validator for global::Alohi.Signplus.Models.ListEnvelopesRequest model.
/// Defines validation rules for required fields, formats, ranges, and constraints based on the API schema.
/// Automatically validates instances during request serialization and response deserialization.
/// </summary>
public class ListEnvelopesRequestValidator
    : AbstractValidator<global::Alohi.Signplus.Models.ListEnvelopesRequest>
{
    public ListEnvelopesRequestValidator()
    {
        RuleFor(ListEnvelopesRequest => ListEnvelopesRequest.Name)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Name cannot be null when provided.");
        RuleFor(ListEnvelopesRequest => ListEnvelopesRequest.Tags)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Tags cannot be null when provided.");
        RuleFor(ListEnvelopesRequest => ListEnvelopesRequest.Comment)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Comment cannot be null when provided.");
        RuleFor(ListEnvelopesRequest => ListEnvelopesRequest.Ids)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Ids cannot be null when provided.");
        RuleFor(ListEnvelopesRequest => ListEnvelopesRequest.Statuses)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Statuses cannot be null when provided.");
        RuleFor(ListEnvelopesRequest => ListEnvelopesRequest.FolderIds)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field FolderIds cannot be null when provided.");
        RuleFor(ListEnvelopesRequest => ListEnvelopesRequest.OnlyRootFolder)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field OnlyRootFolder cannot be null when provided.");
        RuleFor(ListEnvelopesRequest => ListEnvelopesRequest.DateFrom)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field DateFrom cannot be null when provided.");
        RuleFor(ListEnvelopesRequest => ListEnvelopesRequest.DateTo)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field DateTo cannot be null when provided.");
        RuleFor(ListEnvelopesRequest => ListEnvelopesRequest.Uid)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Uid cannot be null when provided.");
        RuleFor(ListEnvelopesRequest => ListEnvelopesRequest.First)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field First cannot be null when provided.");
        RuleFor(ListEnvelopesRequest => ListEnvelopesRequest.Last)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Last cannot be null when provided.");
        RuleFor(ListEnvelopesRequest => ListEnvelopesRequest.After)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field After cannot be null when provided.");
        RuleFor(ListEnvelopesRequest => ListEnvelopesRequest.Before)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Before cannot be null when provided.");
        RuleFor(ListEnvelopesRequest => ListEnvelopesRequest.OrderField)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field OrderField cannot be null when provided.");
        RuleFor(ListEnvelopesRequest => ListEnvelopesRequest.Ascending)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field Ascending cannot be null when provided.");
        RuleFor(ListEnvelopesRequest => ListEnvelopesRequest.IncludeTrash)
            .Must(opt => !opt.IsProvided || opt.Value != null)
            .WithMessage("Field IncludeTrash cannot be null when provided.");
    }
}
