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
        public string QuestionAnswer { get; set; }
        public string Audio { get; set; }
        public string Video { get; set; }
        public string Pictures { get; set; }
    }
}
