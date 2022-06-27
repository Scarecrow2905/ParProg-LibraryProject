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

        public UserDatabase userDatabase;
        public LoginManager loginManager;
        public BookDataBase bookDatabase;
        public BookManager bookManager;

        public Library(string name)
        {
            userDatabase = new UserDatabase();
            loginManager = new LoginManager(this);
            bookDatabase = new BookDataBase();
            bookManager = new BookManager(this);
            Name = name;
        }
    }
}
