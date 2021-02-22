using Core.Entities;
using Core.Utilities.Results;
using EBook.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace EBook.Entities.Concrete
{
    public class Teacher:User,IEntity
    {
        public int TeacherId { get; set; }
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public int ContextId { get; set; }
        public int Department { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}