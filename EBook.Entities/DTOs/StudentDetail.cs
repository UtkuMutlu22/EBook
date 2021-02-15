using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.DTOs
{
    public class StudentDetail:IDto
    {
        public string TypeName { get; set; }
        public string  StudentName { get; set; }
        public string StudentLastName { get; set; }
        public string StepName { get; set; }
        public string GroupName { get; set; }
        public string TeacherName { get; set; }
        public bool Status { get; set; }
    }
}
