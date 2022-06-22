using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject
{
    internal class Customer : User

    {
    public Customer(string userName, string password, bool isAdmin) : base(userName, password, isAdmin)
    {

    }

    protected override void LogIn()
    {
        var userName = Console.ReadLine();
        var password = Console.ReadLine();
        // Sjekker om alt stemmer - Metode her
        Console.WriteLine("Du er logget inn");
        // LoggedInn(user) vise sida utifra hvem som logget inn
    }


    protected override void LogOut()
    {

    }
    }
}
