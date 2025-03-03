using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący z klawiatury liczbę całkowitą i wypisujący na ekranie sześcian
            //wczytanej liczby.
            int a;
            Console.WriteLine("Podaj liczbe całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a^3={0}", a * a * a);
            Console.ReadKey(true);

        }
    }
}
