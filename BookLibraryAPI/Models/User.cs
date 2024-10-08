﻿namespace BookLibraryAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public IEnumerable<BookBorrow>? BookBorrow { get; set; }
        public IEnumerable<Role>? Role { get; set; }

    }
}
