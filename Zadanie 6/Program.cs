using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i
            //iloraz.
            double a, b;
            Console.WriteLine("Podaj a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Suma twoich liczb to: {0}", a+b);
            Console.WriteLine("Różnica twoich liczb to {0}", a-b);
            Console.WriteLine("Iloczyn twoich liczb to {0}", a*b);
            Console.WriteLine("Iloraz twoich liczb to {0}", a/b);

            Console.ReadKey(true);

        }
    }
}
