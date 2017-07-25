using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassroomLibrary.Models
{
    public class BookLevel
    {
        public int ID { get; set; }
        public string FAndP { get; set; }
        public int Lexile { get; set; }
        public int DRA { get; set; }
        public int GradeLevel { get; set; }
    }
}
