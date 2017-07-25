using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassroomLibrary.Models
{
    public class UserLibrary
    {
        public int ID { get; set; }

        public string Title { get; set; }
        public string AuthorFName { get; set; }
        public string AuthorLName { get; set; }
        public string Genre { get; set; }
        public Category Category { get; set; }
        public int BookLevel { get; set; }
        public User AUser { get; set; }

       // public int UserID { get; set; }
    }
}
