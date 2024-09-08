namespace BookLibrary.Models
{
    public class BookInfo
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get;set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Book> Books { get; set; }

        public string GetAuthorName()
        {
            if (Author == null)
                return string.Empty;

            return $"{Author.FirstName} {Author.LastName}";
        }

        public string GetCategory()
        {
            if (Category == null)
                return string.Empty;

            return Category.Type;
        }
    }
}
