using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject.BookGenres
{
    internal class Crime : Ibook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public int Pages { get; set; }
        public string AgeRange { get; set; }
        public string Description { get; set; }
        public bool Available { get; set; }
        public int Stock { get; set; }

        public Crime(string title, string author, int publicationYear, int pages, string ageRange, string description, bool available, int stock)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Pages = pages;
            AgeRange = ageRange;
            Description = description;
            Available = available;
            Stock = stock;
        }
    }
}
