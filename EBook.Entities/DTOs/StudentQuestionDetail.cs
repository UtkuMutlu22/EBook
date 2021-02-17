using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.DTOs
{
    public class StudentQuestionDetail:IDto
    {
        public string StudentName { get; set; }
        public string TeacherName { get; set; }
        public string AnswerText { get; set; }
        public string AnswerAudio { get; set; }
        public string AnswerVideo { get; set; }
        public string AnswerPicture { get; set; }
        public bool QuestionState { get; set; }
    }
}
