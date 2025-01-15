namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class DynamicFieldValidator : AbstractValidator<DynamicField?>
{
    public DynamicFieldValidator() { }
}
