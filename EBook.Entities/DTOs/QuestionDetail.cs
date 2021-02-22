using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.DTOs
{
    public class QuestionDetail:IDto
    {
        public string BookName { get; set; }
        public string QuestionText { get; set; }
        public int QuestionAnswer { get; set; }
        public int QuestionAudio { get; set; }
        public int QuestionVideo { get; set; }
        public int QuestionPicture { get; set; }
    }
}
