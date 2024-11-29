using BookLibrary.Models;
using FluentValidation;

namespace BookLibraryAPI.Models.Validation
{
    public class CreateUserValidation: CustomValidator<User>
    {
        public CreateUserValidation() 
        {
            RuleFor(user => user.Email).NotNull().WithMessage("Email cannot be null");
            RuleFor(user => user.Email).NotEmpty().WithMessage("Email cannot be empty");
            RuleFor(user => user.Password).NotNull().WithMessage("Password cannot be null");
            RuleFor(user => user.Password).NotEmpty().WithMessage("Password cannot be empty");
            RuleFor(user => user.Name).NotNull().WithMessage("Name cannot be null");
            RuleFor(user => user.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(user => user.Phone).NotNull().WithMessage("Phone cannot be null");
            RuleFor(user => user.Phone).NotEmpty().WithMessage("Phone cannot be empty");
            RuleFor(user => user.Address).NotNull().WithMessage("Address cannot be null");
            RuleFor(user => user.Address).NotEmpty().WithMessage("Address cannot be empty");
        }
    }
}
