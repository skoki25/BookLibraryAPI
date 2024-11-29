﻿using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Model.DTO
{
    public class CategoriesWithBooks
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public IEnumerable<BookInfo>? BookInfo { get; set; }
    }
}
