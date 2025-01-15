namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class TemplateRecipientValidator : AbstractValidator<TemplateRecipient?>
{
    public TemplateRecipientValidator() { }
}
