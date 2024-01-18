using BookStore.Models.Requests;
using FluentValidation;

namespace BookStore.BL.Validation
{
    public class AuthorIdValidation : AbstractValidator<GetAllBookByAuthorRequest>
    {
        public AuthorIdValidation()
        {
            RuleFor(x => x.AuthorId)
                .NotNull()
                .GreaterThan(0).WithMessage("AuthorId cannot be less than 0")
                .LessThan(5).WithMessage("AuthorId cannot be larger than 5");

            RuleFor(x => x.DateAfter)
                .NotNull()
                .NotEmpty().WithMessage("You need to insert a date!")
                .LessThan(DateTime.Now).WithMessage("Date cannot be later than today!");

        }
    }
}
