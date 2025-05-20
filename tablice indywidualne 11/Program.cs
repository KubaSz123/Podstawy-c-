using System;

namespace tablice_indywidualne_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wczytaj liczbę naturalną n i wypisz na ekranie tę liczbę w systemie ósemkowym.

            int[] tab = new int[1000]; // tablica na cyfry systemu ósemkowego
            int i = 0, j, liczba;

            Console.Write("Podaj liczbę naturalną: ");
            liczba = Convert.ToInt32(Console.ReadLine());

            if (liczba == 0)
            {
                Console.WriteLine("Liczba w systemie ósemkowym: 0");
                return;
            }

            // zamiana liczby na system ósemkowy (od końca)
            while (liczba > 0)
            {
                tab[i++] = liczba % 8;
                liczba /= 8;
            }

            // wypisujemy cyfry w odwrotnej kolejności
            Console.Write("Liczba w systemie ósemkowym: ");
            for (j = i - 1; j >= 0; j--)
            {
                Console.Write(tab[j]);
            }

            Console.WriteLine(); // nowa linia
            Console.ReadKey();   // pauza
        }
    }
}
