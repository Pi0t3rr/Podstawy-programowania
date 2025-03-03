using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {// Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód.
            double a, b;
            Console.WriteLine("Podaj długości prostokąta");
                Console.WriteLine("Podaj długość boku a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj długośc boku b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Obwód twojego prostokąta wynosi: {0}", 2 * a + 2 * b);
            Console.WriteLine("A pole wynosi: {0}", a * b);
            Console.ReadKey(true);
        }
    }
}
