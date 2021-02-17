using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class Price:IEntity
    {
        public int PriceId { get; set; }
        public int ContextId { get; set; }
        public int StudentId { get; set; }
        public decimal Amount { get; set; }
    }
}
