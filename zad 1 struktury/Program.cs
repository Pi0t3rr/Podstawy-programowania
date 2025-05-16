using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1_struktury
{

    struct Osoba
    {
        public string imie, nazwisko;
        public int rok_urodzenia;

    }
        


    class Program
    {
    static void Main(string[] args)
        {
            //            Zdefiniuj strukturę o nazwie Osoba posiadającą trzy pola: imie, nazwisko i rok_urodzenia.
            //Zadeklaruj zmienną typu strukturalnego o nazwie o, wczytaj do niej wszystkie wartości pól od
            //użytkownika i wypisz wszystkie pobrane wartości pól na ekranie.

            Osoba x;
            Console.WriteLine("Podaj imię: ");
            x.imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            x.nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj rok urodzenia: ");
            x.rok_urodzenia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("osobnik {0} {1} urodził się w {2} roku.", x.imie, x.nazwisko, x.rok_urodzenia);
            Console.ReadKey(true);


            
                


        }   
    }
}
