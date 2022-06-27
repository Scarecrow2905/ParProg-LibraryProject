using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject
{
    public abstract class User
    {
        public string UserName { get; protected set; }
        public string Password { get; protected set; }
        public bool IsAdmin { get; protected set; }
        public bool IsLoggedInn { get; protected set; }

        protected User(string userName, string password, bool isAdmin)
        {
            UserName = userName;
            Password = password;
            IsAdmin = isAdmin;
        }

        //protected abstract bool checkUserName();
        //protected abstract bool checkPassword();
        //public abstract bool LogIn();
        //protected abstract void LogOut();
    }
}
