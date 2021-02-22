using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Concrete
{
    public class Publisher:IEntity
    {

        public int PublisherId { get; set; }
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        public string PublisherName { get; set; }
        public int  PublisherCity { get; set; }
        public int PublisherPhoto { get; set; }
    }
}
