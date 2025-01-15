namespace Alohi.Signplus.Validation;

using System.Collections.Generic;
using FluentValidation;
using FluentValidation.Results;

public class ListValidator<T> : AbstractValidator<List<T>?>
{
    public ListValidator<T> WithMaximumCount(int maxCount)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(list => list).Must(list => list == null || list.Count <= maxCount);
            }
        );
        return this;
    }

    public ListValidator<T> WithMinimumCount(int minCount)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(list => list).Must(list => list == null || list.Count >= minCount);
            }
        );
        return this;
    }

    public ListValidator<T> WithUniqueItems()
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(list => list)
                    .Must(list => list == null || list.Distinct().Count() == list.Count);
            }
        );
        return this;
    }

    public ValidationResult ValidateOptionalList(List<T>? value)
    {
        if (value == null)
        {
            return new ValidationResult();
        }
        return Validate(value);
    }

    public ValidationResult ValidateRequiredList(List<T>? value)
    {
        if (value == null)
        {
            return new ValidationResult(
                new[]
                {
                    new ValidationFailure(nameof(value), "Value is required and cannot be null."),
                }
            );
        }
        return Validate(value);
    }
}
