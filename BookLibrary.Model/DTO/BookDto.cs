using BookLibraryAPI.Models;

namespace BookLibraryAPI.DTO
{
    public class BookDto
    {
        public int Id { get; set; }
        public int BookInfoId { get; set; }

        public string EanCode { get; set; }
        public string ISO { get; set; }
        public BookInfoDto? BookInfo { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}
