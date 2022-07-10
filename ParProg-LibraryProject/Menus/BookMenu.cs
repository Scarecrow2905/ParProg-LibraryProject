using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject.Menus
{
    internal class BookMenu : Menu
    {
        private Menu bookMenu;

        public BookMenu(string name, string description, bool isActive)
        : base(name, description, isActive)
        {
            
        }
    }
}
