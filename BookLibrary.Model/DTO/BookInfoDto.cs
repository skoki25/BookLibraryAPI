using BookLibrary.Models;

namespace BookLibrary.Model.DTO
{
    public class BookInfoDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }

        public string GetAuthorName()
        {
            return Author?.FirstName ?? string.Empty + " " + Author?.LastName ?? string.Empty;
        }

        public string GetCategory()
        {
            return Category?.Type ?? string.Empty;
        }
    }
}
