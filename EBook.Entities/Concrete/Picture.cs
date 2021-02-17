using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class Picture:IEntity
    {
        public int PictureId { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public int RemakId { get; set; }
        public string PictureName { get; set; }
        public string PicturePath { get; set; }
    }
}
