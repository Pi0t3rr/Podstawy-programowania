using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Napisz program wczytujący dwie liczby całkowite a oraz b(a < b) i obliczający sumę kolejnych
            //liczb całkowitych począwszy od liczby a, a skończywszy na liczbie b. Obliczoną sumę wypisz
            //na ekranie.Użyj pętli while.Np.dla a = -2 i b = 5 obliczamy sumę(-2)+(-1) + 0 + 1 + 2 + 3 + 4 + 5.

            int a, b, suma, i;
            Console.WriteLine("podaj a (muis być większe od b): ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = Convert.ToInt32(Console.ReadLine());
            suma = 0;
            i = a;
            while (i <= b)
            {
                suma += i;
                i++;
            }
            Console.WriteLine("Suma kolejnych liczb całkowitych zaczynając od {0} i kończąc na {1} to: {2}", a, b, suma);
            Console.ReadKey(true);




            }

        }
    }

