using Core.Entities;
using EBook.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class Student:User,IEntity
    {
    
        public int TeacherId { get; set; }
        public int StepId { get; set; }
        public int GroupId { get; set; }
        public bool Status { get; set; }
    }
}
