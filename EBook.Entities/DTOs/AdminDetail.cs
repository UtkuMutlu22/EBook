using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.DTOs
{
    public class AdminDetail:IDto
    {
        public string Name { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Mail { get; set; }
    }
}
