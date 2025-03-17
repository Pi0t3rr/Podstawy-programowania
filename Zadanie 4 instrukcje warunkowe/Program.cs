using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4_instrukcje_warunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej
            //największej z tych liczb.

            double a, b, c, d, e, min, max;
            Console.WriteLine("Podaj liczbę nr 1: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbę nr 2: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbę nr 3: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbę nr 4: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj liczbę nr 5: ");
            e = Convert.ToDouble(Console.ReadLine());

            min = a;
            if (b < a) min = b;
            if (c < a) min = c;
            if (d < a) min = d;
            if (e < a) min = e;
            Console.WriteLine("Liczba {0} jest najmniejsza", min);
            max = a;
            if (b > a) max = b;
            if (c > a) max = c;
            if (d > a) max = d;
            if (e > a) max = e;
            Console.WriteLine("Liczba {0} jest największa", max);
            Console.ReadKey(true);




        }
    }
}
