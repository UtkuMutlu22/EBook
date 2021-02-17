using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
   public  class Audio:IEntity
    {
        public int AudioId { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public int RemakId { get; set; }
        public string AudioName { get; set; }
        public string AudioPath { get; set; }
    }
}
