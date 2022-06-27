using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProg_LibraryProject
{
    static class ParprogExtensions
    {
       public static string ReverseString(this string str)
        {
            var chaArray = str.ToCharArray();
            Array.Reverse(chaArray);
            return new string(chaArray);
        }
    }
}
