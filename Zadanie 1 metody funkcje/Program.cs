using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1_metody_funkcje
{
    internal class Program
    {
        
        
            //            Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami
            //całkowitymi.Napisz program wykorzystujący funkcję suma.

            static int suma(int a, int b)
            {
                return a + b;
            }
        static void Main(string[] args)
        {
            Console.WriteLine("3+8={0} ", suma(3, 8));
            Console.ReadKey(true);



            }
        
    }
}
