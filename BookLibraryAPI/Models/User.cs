﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace BookLibraryAPI.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; }
        [JsonIgnore(Condition= JsonIgnoreCondition.WhenWritingDefault)]
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public IEnumerable<BookBorrow>? BookBorrow { get; set; }
        public IEnumerable<Role>? Role { get; set; }

    }
}
