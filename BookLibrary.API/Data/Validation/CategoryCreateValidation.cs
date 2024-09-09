using BookLibrary.Models;
using FluentValidation;

namespace BookLibraryAPI.Models.Validation
{
    public class CategoryCreateValidation: CustomValidator<Category>
    {
        public CategoryCreateValidation()
        {
            RuleFor(category => category.Type).NotNull().WithMessage("Cannot Be Null");
            RuleFor(category => category.Type).NotEmpty().WithMessage("Cannot Be empty");
        }
    }
}
