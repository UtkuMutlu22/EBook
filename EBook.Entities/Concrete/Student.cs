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

        [Key]
        public int StudentId { get; set; }
        public int ConsulantTeacher { get; set; }


    }
}
