using System;

class Program
{
    static void Main()
    {
        int[] tab = new int[1000]; // tablica na cyfry heksadecymalne
        int i = 0, j, liczba;

        Console.Write("Podaj liczbę naturalną: ");
        liczba = Convert.ToInt32(Console.ReadLine());

        if (liczba == 0)
        {
            Console.WriteLine("Liczba w systemie szesnastkowym: 0");
            return;
        }

        // zapisujemy cyfry szesnastkowe do tablicy (od końca)
        while (liczba > 0)
        {
            tab[i++] = liczba % 16;
            liczba /= 16;
        }

        Console.Write("Liczba w systemie szesnastkowym: ");
        for (j = i - 1; j >= 0; j--)
        {
            if (tab[j] < 10)
                Console.Write(tab[j]);
            else
                Console.Write((char)('A' + tab[j] - 10)); // 10 -> A, 11 -> B, ..., 15 -> F
        }

        Console.WriteLine();
        Console.ReadKey(); // pauza
    }
}
