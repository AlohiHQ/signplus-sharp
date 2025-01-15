namespace Alohi.Signplus.Validation;

using FluentValidation;

public class NumberValidator : AbstractValidator<long?>
{
    public NumberValidator WithGreaterThan(long min)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(num => num).Must(num => num > min);
            }
        );
        return this;
    }

    public NumberValidator WithGreaterThanOrEqualTo(long min)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(num => num).GreaterThanOrEqualTo(min);
            }
        );
        return this;
    }

    public NumberValidator WithLessThan(long max)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(num => num).Must(num => num < max);
            }
        );
        return this;
    }

    public NumberValidator WithLessThanOrEqualTo(long max)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(num => num).LessThanOrEqualTo(max);
            }
        );
        return this;
    }

    public NumberValidator WithMultipleOf(long multipleOf)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(num => num).Must(value => value % multipleOf == 0);
            }
        );
        return this;
    }
}
