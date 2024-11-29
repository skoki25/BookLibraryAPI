using BookLibrary.Models;
using FluentValidation;

namespace BookLibraryAPI.Models.Validation
{
    public class CreateBookInfoValidation: CustomValidator<BookInfo>
    {
        public CreateBookInfoValidation() 
        {
            RuleFor(bookInfo => bookInfo.Title).NotNull().WithMessage("Title cant be null");
            RuleFor(bookInfo => bookInfo.Title).NotEmpty().WithMessage("Title cant be empty");
            RuleFor(bookInfo => bookInfo.Description).NotNull().WithMessage("Description cant be null");
            RuleFor(bookInfo => bookInfo.Description).NotEmpty().WithMessage("Description cant be empty");
            RuleFor(bookInfo => bookInfo.AuthorId).NotNull().WithMessage("AuthorId cant be null");
            RuleFor(bookInfo => bookInfo.CategoryId).NotNull().WithMessage("CategoryId cant be null");
        }
    }
}
