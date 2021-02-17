using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.DTOs
{
    public class VideoDetail:IDto
    {
        public string VideoName { get; set; }
        public string TeacherName { get; set; }
        public string RemakText { get; set; }
    }
}
