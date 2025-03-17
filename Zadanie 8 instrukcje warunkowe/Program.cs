using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8_instrukcje_warunkowe
{
    internal class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący trzy długości odcinków i wypisujący na ekranie informację czy
            //da się z tych odcinków zbudować trójkąt, czy też nie.
            double a, b, c;
            Console.WriteLine("Podaj trzy długości trójkąta: ");
            Console.WriteLine("Pierwsza długość: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Druga długość: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Trzecia długość: ");
            c = Convert.ToDouble(Console.ReadLine());

            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
                Console.WriteLine("Z podanych długości można zrobić trójkąt.");
            else
                Console.WriteLine("Z podanych długości nie można zrobić trójkąta.");
            Console.ReadKey(true);

        }
    }
}
