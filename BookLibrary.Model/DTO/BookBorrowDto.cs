using BookLibraryAPI.Models;

namespace BookLibraryAPI.DTO
{
    public class BookBorrowDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public BookDto? Book { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public DateTime? ReturnedDated { get; set; }
        public bool IsReturned { get; set; }
    }
}
