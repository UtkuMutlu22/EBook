using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.DTOs
{
   public class AudioDetail:IDto
    {
        public int AudioId { get; set; }
        public string AudioName { get; set; }
        public string StudentName { get; set; }
        public string TeacherName { get; set; }
        public string RemakText { get; set; }
    }
}
