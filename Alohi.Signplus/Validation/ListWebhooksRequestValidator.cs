namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class ListWebhooksRequestValidator : AbstractValidator<ListWebhooksRequest?>
{
    public ListWebhooksRequestValidator() { }
}
