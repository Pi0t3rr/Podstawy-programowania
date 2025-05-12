using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4M
{
    internal class Program
    {
        static int ile_cyfr(int liczba)
        {
            int i = 0;
            while (liczba / 10 > 0)
            {
                liczba /= 10;
                i++;

            }
            return i + 1;

        }



        static void Main(string[] args)
        {//4. Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jako
         // argument tej funkcji.Napisz program wykorzystujący funkcję ile_cyfr

            Console.WriteLine("Liczba 2 ma {0} cyfrę", ile_cyfr(2));
            Console.WriteLine("Liczba 345 ma {0} cyfry", ile_cyfr(345));
            Console.ReadKey(true);

        }
    }
}

