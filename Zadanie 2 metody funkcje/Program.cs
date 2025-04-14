using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_metody_funkcje
{
    internal class Program
    {
            //Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych
            //zadanych jako argumenty tej funkcji.Napisz program wykorzystujący funkcję max

        static double max(double a, double b)
        {
            if (a > b) return a;
            else return b;


        }
        static void Main(string[] args) { 
        Console.WriteLine("Max z 5 i 10 to: {0}", max (5, 10));
        Console.WriteLine("Max z 10 i 5 to: {0}", max(10, 5));
        Console.WriteLine("Max z 5 i 5 to: {0}", max(5, 5));
            Console.ReadKey(true);


        }
    }
}
