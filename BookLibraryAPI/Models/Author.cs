﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibraryAPI.Models
{
    public class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
    }
}