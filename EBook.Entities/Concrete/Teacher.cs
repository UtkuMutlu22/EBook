using Core.Entities;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace EBook.Entities.Concrete
{
    public class Teacher:IEntity
    {
        public int TeacherId { get; set; }
        public int Class { get; set; }
        public int StudentsId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherLastName { get; set; }
        public string TeacherMail { get; set; }
        public string TeacherPassword { get; set; }
    }
}