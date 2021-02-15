using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class Group:IEntity
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
    }
}
