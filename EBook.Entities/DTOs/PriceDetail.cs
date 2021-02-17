using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.DTOs
{
    public class PriceDetail:IDto
    {
        public string ContextName { get; set; }
        public string StudentName { get; set; }
        public string Amount { get; set; }
    }
}
