using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class Video:IEntity
    {
        public int VideoId { get; set; }
        public int TeacherId { get; set; }
        public int RemakId { get; set; }
        public string VideoName { get; set; }
        public string VideoPath { get; set; }
    }
}
