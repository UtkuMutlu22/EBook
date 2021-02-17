using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class Remak:IEntity
    {
        public int RemakId { get; set; }
        public int Owner { get; set; }
        public int ContextId { get; set; }
        public string Text { get; set; }


    }
}
