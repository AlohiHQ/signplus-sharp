namespace Alohi.Signplus.Validation;

using Alohi.Signplus.Models;
using FluentValidation;
using FluentValidation.Results;

public class AnnotationDateTimeValidator : AbstractValidator<AnnotationDateTime?>
{
    public AnnotationDateTimeValidator() { }
}
