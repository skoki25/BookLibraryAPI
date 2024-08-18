using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibraryAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int BookInfoId { get;set; }

        public string EanCode { get; set; }
        public string ISO {  get; set; }
        public BookInfo? BookInfo { get; set; }
        public DateTime PublicationDate { get; set; }
        public IEnumerable<BookBorrow>? BookBorrow {get; set; }
    }
}
