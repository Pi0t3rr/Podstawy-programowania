using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5M
{
    internal class Program
    {
        static int czy_pierwsza(int liczba)
        {

            int i;
            for (i = 2; i < liczba / 2; i++)
                if (liczba % i == 0) return 0;
            return 1;

        }

        static void Main(string[] args)
        {
            //            Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą.Jako wartość funkcja
            //powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb.Przetestuj działanie
            //utworzonej funkcji

            Console.WriteLine("Czy 24 jest liczba pierwsza: {0}", czy_pierwsza(24));
            Console.WriteLine("Czy 17 jest liczba pierwsza: {0}", czy_pierwsza(17));
            Console.ReadKey(true);












        }
    }
}
