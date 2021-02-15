using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class StudentQuestion:Question,IEntity
    {
        public byte State { get; set; }
    }
}
