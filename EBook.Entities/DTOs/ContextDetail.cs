using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.DTOs
{
    public class ContextDetail:IDto
    {
        public string BookName { get; set; }
        public string PublisherName { get; set; }
        public int BookTitle { get; set; }
        public string ContextText { get; set; }
        public string QuestionText { get; set; }
        public int QuestionAnswer { get; set; }
        public int QuestionAudio { get; set; }
        public int QuestionVideo { get; set; }
        public int QuestionPicture { get; set; }
        public int Remak { get; set; }
    }
}
