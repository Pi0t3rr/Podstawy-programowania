using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3_tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Napisać program wczytujący ciąg n(1 <= n <= 1000) liczb całkowitych, sortujący je niemalejąco i
            //wypisujący posortowane liczby na ekranie.
           
            int[] tablica = new int[1000];
            int i, n, j, x;
            Console.WriteLine("Podaj ilość elementów tablicy n <=1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj tablice[{0}]= ", i);
                tablica[i] = Convert.ToInt32(Console.ReadLine());
            }
                for(i=0;i<n;i++)
                    for(j=i+1;j<n;j++)
                        if (tablica[i] > tablica[j])
                        { x = tablica[i]; tablica[i] = tablica[j]; tablica[j] = x;}
                Console.WriteLine("Elementy tablicy: ");
                    for (i = 0; i < n; i++)
                {
                    Console.WriteLine("{0} ", tablica[i]);

                }
                    Console.ReadKey(true);
            }




        
    }
}
