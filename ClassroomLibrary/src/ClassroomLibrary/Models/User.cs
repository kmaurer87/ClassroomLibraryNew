using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassroomLibrary.Models
{
    public class User
    {
        public int ID { get; set; }

        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
       public ICollection<Book> UserBooks { get; set; }
        public User()
        {
            UserBooks = new HashSet<Book>();
        }
         
    }
}
