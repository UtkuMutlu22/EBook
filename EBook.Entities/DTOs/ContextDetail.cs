using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.DTOs
{
    public class ContextDetail:IDto
    {
        public string BookName { get; set; }
        public string BookTitle { get; set; }
        public string QuestionText { get; set; }
        public string QuestionAnswer { get; set; }
        public string QuestionAudio { get; set; }
        public string QuestionVideo { get; set; }
        public string QuestionPicture { get; set; }
        public string Remak { get; set; }
    }
}
