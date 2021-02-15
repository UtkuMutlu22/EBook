using Core.Entities;
using Core.Utilities.Results;
using EBook.Entities.Abstract;
using System.Collections.Generic;

namespace EBook.Entities.Concrete
{
    public class Teacher:User,IEntity
    {
       
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public int GroupId { get; set; }
        public int ConsulantStudent { get; set; }
        public bool Status { get; set; }
    }
}