using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class City:IEntity
    {
        public int CıtyId { get; set; }
        public string CityName { get; set; }
    }
}
