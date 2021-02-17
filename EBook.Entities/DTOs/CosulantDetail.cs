using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.DTOs
{
    public class CosulantDetail:IDto
    {
        public string ConsulantName { get; set; }
        public string ConsulantLastName { get; set; }
        public string StudentName { get; set; }
        public string ConsulantSpeciality { get; set; }
    }
}
