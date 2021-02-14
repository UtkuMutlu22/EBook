using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class Student:IEntity
    {
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public int ClassId { get; set; }
        public int Level { get; set; }
        public int ConstulantId { get; set; }
        public string StudentName { get; set; }
        public string StudentLastName { get; set; }
        public string StudentMail { get; set; }
        public string StudentPassword { get; set; }
    }
}
