using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class Context : IEntity
    {
        public int ContextId { get; set; }
        public int PublisherId { get; set; }
        public int BookId { get; set; }
        public int QuestionId { get; set; }
        public int TeacherId { get; set; }
        public string ContextText { get; set; }
        public int ContextAudio { get; set; }
        public int ContextVideo { get; set; }
        public int ContextPicture { get; set; }
        public int RemakId { get; set; }



    }
}
