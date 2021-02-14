using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class Classes:IEntity
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    }
}
