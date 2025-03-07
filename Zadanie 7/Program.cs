using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie iloraz tych liczb z
            //uwzględnieniem części całkowitej i reszty z dzielenia.

            int a, b;
            Console.WriteLine("Podaj liczbę całkowita a: ");
                a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj liczbę całkowitą b: ");
                b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iloraz wynosi: {0}/{1}", a, b);
            Console.WriteLine("Część całkowita: {0}", a/b);
            Console.WriteLine("Reszta jest równa: {0}", a%b);

            Console.ReadKey(true);
           

        }
    }
}
