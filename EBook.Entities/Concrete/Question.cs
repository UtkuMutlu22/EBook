using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class Question:IEntity
    {
        public int QuestionId { get; set; }
        public int BookId { get; set; }
        public string QuestionText { get; set; }
        public int QuestionAnswer { get; set; }
        public int QuestionAudio { get; set; }
        public int QuestionVideo { get; set; }
        public int QuestionPicture { get; set; }
    }
}
