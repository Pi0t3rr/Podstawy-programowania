using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2_struktury
{
    struct Uczen
    {
        public string imie, nazwisko;
        public byte[] oceny;


    }
    class Program
    {
        static void Main(string[] args)
        {
            //            Zdefiniuj strukturę o nazwie Uczen zawierającą pola: imie, nazwisko i tablice ocen.
            //            Pobierz od użytkownika liczbę uczniów i zadeklaruj odpowiednią tablicę struktur
            //umożliwiającą przechowanie informacji o imionach, nazwiskach i ocenach uczniów.
            //Następnie pobierz dane od użytkownika i w sposób czytelny wypisz wszystko na ekranie.

            Uczen[] uczniowie;
            int ile_osob, ile_ocen, i, j;
            Console.Write("Podaj ilość uczniów w klasie: ");
            ile_osob = Convert.ToInt32(Console.ReadLine());
            uczniowie = new Uczen[ile_osob];
            for (i = 0; i < ile_osob; i++)
            {
                Console.Write("Podaj imię ucznia {0} ", i + 1);
                uczniowie[i].imie = Console.ReadLine();
                Console.Write("Podaj nazwisko ucznia {0} ", i + 1);
                uczniowie[i].nazwisko = Console.ReadLine();
                Console.Write("Ile ocen ma {0} {1}: ", uczniowie[i].imie, uczniowie[i].nazwisko);
                ile_ocen = Convert.ToInt32(Console.ReadLine());
                uczniowie[i].oceny = new byte[ile_ocen];

                for (j = 0; j < ile_ocen; j++)
                {
                    Console.Write("Podaj ocene numer {0} ", j + 1);
                    uczniowie[i].oceny[j] = Convert.ToByte(Console.ReadLine());
                }

                Console.WriteLine();

            }
            for (i = 0; i < ile_osob; i++)
            {

                Console.Write("{0}. {1} {2}: ", i + 1, uczniowie[i].imie, uczniowie[i].nazwisko);
                foreach (byte o in uczniowie[i].oceny)
                    Console.Write(" {0}, ", o);
                Console.WriteLine("");

            }

            Console.ReadKey(true);
        }
    }
}

   







        
    

