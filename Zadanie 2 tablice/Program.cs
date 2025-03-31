using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Napisać program wczytujący ciąg n(1 <= n <= 1000) liczb całkowitych i wypisujący wczytane
            //liczby w odwrotnej kolejności na ekranie.

            int[] tablica = new int[1000];
            int i, n;
            Console.WriteLine("Podaj ilość elementów tablicy n <=1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj tablice[{0}]= ", i);
                tablica[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elementy tablicy: ");
            for (i = n-1; i >=0 ; i--)
            {
                Console.WriteLine("{0} ", tablica[i]);
            }

            Console.ReadKey(true);

        }
    }
}
