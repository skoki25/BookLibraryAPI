using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Model.DTO
{
    public class BookSimpleDto
    {
        public int Id { get; set; }
        public int BookInfoId { get; set; }

        public string EanCode { get; set; }
        public string ISO { get; set; }
        public DateTime PublicationDate { get; set; }
    }
}
