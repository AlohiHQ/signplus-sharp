namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class SetEnvelopeDynamicFieldsRequestValidator
    : AbstractValidator<SetEnvelopeDynamicFieldsRequest?>
{
    public SetEnvelopeDynamicFieldsRequestValidator()
    {
        RuleFor(SetEnvelopeDynamicFieldsRequest => SetEnvelopeDynamicFieldsRequest.DynamicFields)
            .NotNull()
            .WithMessage("Field dynamic_fields is required and cannot be null.");
    }
}
