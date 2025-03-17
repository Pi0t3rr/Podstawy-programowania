using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)

        {//Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i
            //największej z tych liczb.
            double a, b, c;
            Console.WriteLine("Podaj pierwszą liczbe: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbe: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę: ");
            c = Convert.ToDouble(Console.ReadLine());
                if ((a <= b) && (a <= c)) 
                Console.WriteLine("Liczba a jest najmniejsza: {0}", a);
                else if ((b <= a) && (b <= c)) 
                    Console.WriteLine("liczba b jest najmniejsza: {0}", b);
                    else
                        Console.WriteLine("Liczba c jest najmniejsza: {0}", c);

            if ((a >= b) && (a >= c))
                Console.WriteLine("Liczba a jest największa: {0}", a);
            else if ((b >= a) && (b >= c))
                Console.WriteLine("Liczba b jest największa: {0}", b);
            else
                Console.WriteLine("Liczba c jest najwieksza: {0}", c);
                    Console.ReadKey(true);
        
        }
    }
}
