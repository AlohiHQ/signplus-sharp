namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class AddAnnotationRequestValidator : AbstractValidator<AddAnnotationRequest?>
{
    public AddAnnotationRequestValidator()
    {
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.DocumentId)
            .NotNull()
            .WithMessage("Field document_id is required.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.Page)
            .NotNull()
            .WithMessage("Field page is required.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.X)
            .NotNull()
            .WithMessage("Field x is required.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.Y)
            .NotNull()
            .WithMessage("Field y is required.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.Width)
            .NotNull()
            .WithMessage("Field width is required.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.Height)
            .NotNull()
            .WithMessage("Field height is required.");
        RuleFor(AddAnnotationRequest => AddAnnotationRequest.Type_)
            .NotNull()
            .WithMessage("Field type is required.");
    }
}
