using System;

namespace tablice_indywidualne_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych
            // i wypisujący na ekranie sumę kwadratów wczytanych liczb.

            int[] tab = new int[1000]; // tablica na 1000 liczb
            int i;
            int suma = 0, n; // suma musi być zainicjalizowana

            Console.Write("Podaj ilość n w ciągu = ");
            n = Convert.ToInt32(Console.ReadLine()); // poprawnie wczytujemy n

            for (i = 0; i < n; i++) // poprawna pętla
            {
                Console.Write("Podaj tab[{0}]= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine()); // poprawne wczytywanie liczby
            }

            for (i = 0; i < n; i++) // liczymy sumę kwadratów
            {
                suma += tab[i] * tab[i];
            }

            Console.WriteLine("Suma kwadratów wynosi: {0}", suma);
            Console.ReadKey(); // pauza
        }
    }
}
