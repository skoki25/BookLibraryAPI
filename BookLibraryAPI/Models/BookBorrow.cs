using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibraryAPI.Models
{
    public class BookBorrow
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public User? User { get; set; }
        public Book? Book { get; set; }
        public DateTime BorrowDate { get;set; }
        public DateTime ReturnDate { get;set; }
        public DateTime? ReturnedDated { get; set; }
        public bool IsReturned {  get; set; }
    }
}
