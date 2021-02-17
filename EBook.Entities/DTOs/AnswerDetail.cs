using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.DTOs
{
    public class AnswerDetail:IDto
    {
        public int Id { get; set; }
        public string OwnerName { get; set; }
        public string QuestionText { get; set; }
        public int QuestionVideo { get; set; }
        public int QuestionAudio { get; set; }
        public int QuestionPicture { get; set; }
        public string AnswerText { get; set; }
        public int AnswerVideo { get; set; }
        public int AnswerAudio { get; set; }
        public int AnswerPicture { get; set; }
        public int RemakId { get; set; }
    }
}
