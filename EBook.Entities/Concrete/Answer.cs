using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class Answer:IEntity
    {
        public int AnswerId { get; set; }
        public int Owner { get; set; }
        public int Remak { get; set; }
        public string AnswerText { get; set; }
        public int AnswerAudio { get; set; }
        public int AnswerVideo { get; set; }
        public int AnswerPicture { get; set; }

        
    }
}
