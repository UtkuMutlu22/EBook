using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class StudentQuestion:Question,IEntity
    {
        [Key]
        public int StudentQuestionId { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public bool QuestionState { get; set; }
    }
}
