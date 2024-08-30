namespace BookLibraryAPI.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public IEnumerable<User> User { get; set; }
    }
}
