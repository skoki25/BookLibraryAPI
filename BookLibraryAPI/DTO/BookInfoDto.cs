using BookLibraryAPI.Models;

namespace BookLibraryAPI.DTO
{
    public class BookInfoDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
