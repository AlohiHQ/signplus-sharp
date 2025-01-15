namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class AddTemplateDocumentRequestValidator : AbstractValidator<AddTemplateDocumentRequest?>
{
    public AddTemplateDocumentRequestValidator()
    {
        RuleFor(AddTemplateDocumentRequest => AddTemplateDocumentRequest.File)
            .NotNull()
            .WithMessage("Field file is required.");
    }
}
