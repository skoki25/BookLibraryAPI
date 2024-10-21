﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibrary.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public IEnumerable<BookInfo>? BookInfo{ get; set;}

        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " +LastName;
            }
            private set { }
        }

    }
}
