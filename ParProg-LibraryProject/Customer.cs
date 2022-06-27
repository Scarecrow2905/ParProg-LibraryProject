using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject
{
    internal class Customer : User
    {
        private Customer customer;

        public Customer(string userName, string password, bool isAdmin) 
            : base (userName, password, isAdmin)
        {
            
        }


    }


}

