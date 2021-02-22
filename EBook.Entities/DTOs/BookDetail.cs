using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.DTOs
{
    public class BookDetail:IDto
    {
        public int BookId { get; set; }
        public string CategoryName { get; set; }
        public string Publisher { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public DateTime DateOfIssue { get; set; }
    }
}
