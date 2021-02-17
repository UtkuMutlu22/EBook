using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.DTOs
{
    public class AnswerDetail:IDto
    {
        public string OwnerName { get; set; }
        public string QuestionText { get; set; }
        public string QuestionVideo { get; set; }
        public string QuestionAudio { get; set; }
        public string QuestionPicture { get; set; }
    }
}
