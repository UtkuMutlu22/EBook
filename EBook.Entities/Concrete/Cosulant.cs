using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class Cosulant:Teacher,IEntity
    {
        public int ConsulantId { get; set; }
        public int StudentId { get; set; }
        public int CategoryId { get; set; }

    }
}
