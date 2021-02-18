using Core.Entities;
using EBook.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class Admin : User, IEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
