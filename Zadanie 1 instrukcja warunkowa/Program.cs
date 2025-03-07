using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_instrukcja_warunkowa
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to
            //liczba parzysta, czy też nieparzysta.

            int a;
            Console.WriteLine("Podaj liczbę całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());
            if ( a % 2 == 0)
                Console.WriteLine("twoja liczba: {0} jest parzysta", a);
            else
                Console.WriteLine("Twoja liczba: {0} jest nieparzysta",a);
            Console.ReadKey(true);

        }
    }
}
