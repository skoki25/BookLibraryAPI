namespace BookLibrary.Models
{
    public class Category
    {
        public int Id { get; set; } 
        public string Type { get; set; }

        public IEnumerable<BookInfo> BookInfo { get; set; }

    }
}
