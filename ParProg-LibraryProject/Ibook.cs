using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject
{
    public interface Ibook
    {
        string Title { get; set; }
        //public string Genre { get; protected set; }
        string Author { get; set; }
        int PublicationYear { get; set; }
        int Pages { get; set; }
        string AgeRange { get; set; }
        string Description { get; set; }
        bool Available { get; set; }
        int Stock { get; set;  }
       
    }
}
