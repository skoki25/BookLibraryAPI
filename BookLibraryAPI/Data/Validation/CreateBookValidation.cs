using FluentValidation;
using FluentValidation.Results;

namespace BookLibraryAPI.Models.Validation
{
    public class CreateBookValidation: CustomValidator<Book>
    {
        public CreateBookValidation()
        {
            RuleFor(book => book).NotNull();
            RuleFor(book => book.ISO).NotEmpty().WithMessage("Iso cant be empty");
            RuleFor(book => book.ISO).Must(x => x.StartsWith("ISO")).WithMessage("Must start with ISO");
            RuleFor(book => book.EanCode).NotEmpty().WithMessage("Ean cant be empty");
            RuleFor(book => book.PublicationDate).NotNull().WithMessage("Publish date cant be null");
            RuleFor(book => book.BookInfoId).NotNull().WithMessage("BookInfoId cant be null");
        }
    }
}
