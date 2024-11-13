using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class Usuario
    {
        public long id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public string nickname { get; set; }
        public string userType { get; set; }
        public string userStatus { get; set; } 
    }
}
