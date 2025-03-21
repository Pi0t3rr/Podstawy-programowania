using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6_prawdziwe__wcześniejsze_5_i_6_to_są_4_i_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Wczytaj liczbę naturalną n(n> 1). Narysuj na ekranie z gwiazdek trójkąt równoramienny, który
            //nie jest trójkątem prostokątnym.Użyj pętli for. Przykładowo dla n = 3 narysowany trójkąt
            //powinien wyglądać:

            int n, i, j;
            Console.WriteLine("Podaj liczbę naturalną n, większą od 1: ");
                n = Convert.ToInt32(Console.ReadLine());
            for(i = 1; i<=n; i++)
            {
                for(j = 1; j<= n-i; j++) Console.Write(" ");
                for(j = 1; j<= 2*i-1 ; j++) Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
}
