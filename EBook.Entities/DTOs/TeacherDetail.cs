using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.DTOs
{
    public class TeacherDetail:IDto
    {
        public string TeacherName { get; set; }
        public string StudentName { get; set; }
        public string TeacherSpeciality { get; set; }
        
    }
}
