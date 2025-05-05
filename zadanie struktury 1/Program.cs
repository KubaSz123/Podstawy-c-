using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Zdefiniuj strukturę o nazwie Osoba posiadającą trzy pola: imie, nazwisko i rok_urodzenia. Zadeklaruj zmienną typu strukturalnego
//o nazwie o, wczytaj do niej wszystkie wartości pól od użytkownika i wypisz wszystkie pobrane wartości pól na ekranie. 

namespace zadanie_struktury_1
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
            Osoba o;
            Console.Write("Podaj Imie:");
            o.imie = Console.ReadLine();
            Console.Write("Podaj nazwisko");
            o.nazwisko = Console.ReadLine();
            Console.Write("Podaj rok urodzenia");
            o.rok_urodzenia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1} urodzil sie w {2} roku.", o.imie, o.nazwisko, o.rok_urodzenia);
            Console.ReadKey();





                                                    
        }


        }
}

