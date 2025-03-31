using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6_tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Zadeklaruj tablicę zawierającą nazwy dni tygodnia. Wypisz elementy tablicy za pomocą pętli
            //foreach.

            string []dni = new string[7]
            {"poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };
            foreach (string x in dni) Console.Write("{0}, ", x);
            Console.ReadKey(true);
         




        }
    }
}
