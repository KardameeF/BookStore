using ComicBookStore.Models.Requests;
using FluentValidation;

namespace ComicBookStore.Validators
{
    public class SomeRequestValidator : 
        AbstractValidator<SomeRequest>
    {
        public SomeRequestValidator()
        {
            RuleFor(x => x.SomeIntValue)
                .NotNull()
                .GreaterThan(0)
                .LessThan(1000)
                .WithMessage("Some error");

            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .MinimumLength(2)
                .MaximumLength(10);
        }
    }
}
