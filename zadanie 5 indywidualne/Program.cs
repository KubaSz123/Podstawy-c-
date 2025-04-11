using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

        //Wczytaj liczbę naturalną n>0 i oblicz n^n. Nie można używać funkcji matematycznych.

namespace zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            // Wczytanie liczby naturalnej n > 0
            do
            {
                Console.Write("Podaj liczbę naturalną n > 0: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while (n <= 0);

            // Obliczanie n^n bez funkcji matematycznych
            long wynik = 1;
            for (int i = 0; i < n; i++)
            {
                wynik *= n;
            }

            Console.WriteLine($"\n{n}^{n} = {wynik}");
            Console.WriteLine("\nNaciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}