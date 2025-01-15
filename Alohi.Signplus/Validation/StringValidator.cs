namespace Alohi.Signplus.Validation;

using FluentValidation;

public class StringValidator : AbstractValidator<string>
{
    public StringValidator WithMaximumLength(int maxLength)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(str => str).MaximumLength(maxLength);
            }
        );
        return this;
    }

    public StringValidator WithMinimumLength(int minLength)
    {
        When(
            num => num != null,
            () =>
            {
                RuleFor(str => str).MinimumLength(minLength);
            }
        );
        return this;
    }

    public StringValidator WithMatch(string pattern)
    {
        When(
            str => str != null,
            () =>
            {
                RuleFor(str => str).Matches(pattern);
            }
        );
        return this;
    }
}
