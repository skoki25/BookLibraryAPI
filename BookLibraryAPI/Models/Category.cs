﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibraryAPI.Models
{
    public class Category
    {
        public int Id { get; set; } 

        public string Type { get; set; }

    }
}
