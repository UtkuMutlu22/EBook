﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
   public class Book:IEntity
    {
        public int BookId { get; set; }
        public int PublisherId { get; set; }
        public int CategoryId { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public DateTime DateOfIssue { get; set; }
    }
}
