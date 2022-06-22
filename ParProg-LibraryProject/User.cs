using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject
{
    abstract class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        protected User(string userName, string password, bool isAdmin)
        {
            UserName = userName;
            Password = password;
            IsAdmin = isAdmin;
        }

        protected abstract void checkUserName();
        protected abstract void checkPassword();
        protected abstract bool LogIn();
        protected abstract void LogOut();
    }
}
