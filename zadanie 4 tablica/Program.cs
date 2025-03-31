using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4_tablica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Napisać program wczytujący ciąg n(1 <= n <= 1000) liczb całkowitych i wypisujący na ekranie
            //sumę wczytanych liczb.
            int[] tablica = new int[1000];
            int i, n, suma;
            Console.WriteLine("Podaj ilość elementów tablicy n <=1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj tablice[{0}]= ", i);
                tablica[i] = Convert.ToInt32(Console.ReadLine());

            }
            suma = 0;
            for (i = 0; i < n; i++)
            
                suma += tablica[i];
            
            Console.WriteLine("Suma elementów twojej tablicy to: {0}", suma);
            Console.ReadKey(true);


        }
    }
}
