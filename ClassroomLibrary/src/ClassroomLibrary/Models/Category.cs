using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassroomLibrary.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IList<Book> UserLibraries { get; set; }



    }
}
