using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.DTOs
{
    public class BookDto
    {
        public int BookId { get; set; }
        public int Publisher { get; set; }
        public string BookName { get; set; }
        public string BookTitle { get; set; }
        public string Description { get; set; }
        public DateTime DateOfIssue { get; set; }
    }
}
