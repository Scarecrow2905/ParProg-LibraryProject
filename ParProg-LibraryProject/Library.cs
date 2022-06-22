using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject
{
    public class Library
    {
        public string Name { get; set; }
        private UserDatabase userDatabase;
        public BookDatabase bookDatabase;

        public Library(string name)
        {
            userDatabase = new UserDatabase();
            bookDatabase = new BookDatabase();
            Name = name;
        }
    }
}
