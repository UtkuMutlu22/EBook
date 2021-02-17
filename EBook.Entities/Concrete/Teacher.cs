﻿using Core.Entities;
using Core.Utilities.Results;
using EBook.Entities.Abstract;
using System.Collections.Generic;

namespace EBook.Entities.Concrete
{
    public class Teacher:User,IEntity
    {
        public int TeacherId { get; set; }
        public string TeacherSpeciality { get; set; }
    }
}