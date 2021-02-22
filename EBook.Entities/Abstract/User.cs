using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entities.Abstract
{
    public interface User 
    {
        int UserId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Mail { get; set; }
        string Password { get; set; }
        DateTime RegisterDate { get; set; }
    }
        
    
}
