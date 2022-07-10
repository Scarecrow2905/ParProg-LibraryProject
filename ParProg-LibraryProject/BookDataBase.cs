using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParProg_LibraryProject.BookGenres;
using ParProg_LibraryProject.Menus;

namespace ParProg_LibraryProject
{
    public class BookDataBase
    {

        public List<Ibook> BookList;

        public BookDataBase()
        {

            // Her har vi da en liste med alle bøker, bøkene sin sjanger er da de forskjellige klassene. Og alle klassene arver fra et Interface (Ibook)



            //Biography
            Biography SteveJobs =
                new Biography("Steve Jobs", "Walter Isaacson", 2011, 670, "10 +", "Beskrivelse", true, 5);
            Biography BarackObama = new Biography("Et lovende land", "Barack Obama", 2022, 800, "10+",
                "En fengslende og dypt personlig beretning av Barack Obama", true, 10);

            // Crime
            Crime Blodmåne = new Crime("Blodmåne", "Jo Nesbø", 2022, 349, "16+",
                "Ny bok om Harry Hole som har rest til Los Angeles.", true, 8);
            Crime Grenseløs = new Crime("Grenseløs", "Jørn Lier Horst", 2021, 489, "14+",
                "Ny etterforskning for Wisting på et gammel drap", true, 10);


            // Fantasy


            // Horror
            Horror It = new Horror("It", "Stephen King", 1986, 1138, "16+", "Beskrivelse her", true, 8);
            Horror TheExorcist = new Horror("The Exorcist", "William Peter Blatty", 1971, 340, "18+",
                "En beskrivelse her", true, 8);

            BookList = new List<Ibook>();

            BookList.Add(SteveJobs);
            BookList.Add(BarackObama);
            BookList.Add(Blodmåne);
            BookList.Add(Grenseløs);
            BookList.Add(It);
            BookList.Add(TheExorcist);

        }
    }
}
