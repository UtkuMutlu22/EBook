using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class Cosulants:Teacher,IEntity
    {
        public int ConsulantId { get; set; }
    }
}
