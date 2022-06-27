using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject
{
    internal class Admin : User
    {
        private Admin admin;

        public Admin(string userName, string password, bool isAdmin) 
            : base(userName, password, isAdmin)
        {
            
        }

        protected void BookOverview()
        {

        }
    }
}
