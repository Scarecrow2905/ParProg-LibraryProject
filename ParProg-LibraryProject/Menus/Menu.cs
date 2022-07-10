using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject.Menus
{
    internal class Menu
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public bool isActive { get; set; }


        public Menu(string name, string description, bool isActive)
        {
            Name = name;
            Description = description;
            this.isActive = isActive;
        }
    }
}
