using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class Step:IEntity
    {
        public int StepId { get; set; }
        public int StepName { get; set; }
    }
}
