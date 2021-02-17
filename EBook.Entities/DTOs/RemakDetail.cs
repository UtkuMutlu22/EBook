using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.DTOs
{
    public class RemakDetail:IDto
    {
        public string OwnerName { get; set; }
        public string ContextName { get; set; }
        public string Text { get; set; }
    }
}
