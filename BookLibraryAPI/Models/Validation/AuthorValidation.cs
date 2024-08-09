using FluentValidation;

namespace BookLibraryAPI.Models.Validation
{
    public class AuthorValidation:CustomValidator<Author>
    {
        public AuthorValidation() 
        {
            RuleFor(author => author.Age).NotNull().WithMessage("age cannot be null!");
            RuleFor(author => author.FirstName).NotNull().WithMessage("First name cannot be null!");
            RuleFor(author => author.FirstName).NotNull().WithMessage("Second name cannot be null!");
        }
    }
}
