namespace Alohi.Signplus.Validation;

using FluentValidation;
using FluentValidation.Results;

public class FloatValidator : AbstractValidator<double?>
{
    private readonly string _name;

    public FloatValidator(string name)
    {
        _name = name;
    }

    public FloatValidator WithGreaterThan(double min)
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

    public FloatValidator WithGreaterThanOrEqualTo(double min)
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

    public FloatValidator WithLessThan(double max)
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

    public FloatValidator WithLessThanOrEqualTo(double max)
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

    public FloatValidator WithMultipleOf(double multipleOf)
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
