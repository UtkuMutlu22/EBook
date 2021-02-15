using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.DTOs
{
    public class TeacherDetail:IDto
    {
        public string UserType { get; set; }
        public bool Status { get; set; }
        public string ClasName { get; set; }
        public string GroupName { get; set; }
        public string TeacherName { get; set; }
        public string TeacherLastName { get; set; }
        public string ConsulantStudentName { get; set; }

    }
}
