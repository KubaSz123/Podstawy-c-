using System;

class Program
{
    static void Main()
    {
        double[] liczby = new double[5];

        // Wczytywanie pięciu liczb
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Podaj liczbę {i + 1}: ");
            liczby[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Obliczanie wartości najmniejszej i największej
        double min = liczby[0];
        double max = liczby[0];

        foreach (double liczba in liczby)
        {
            if (liczba < min)
                min = liczba;

            if (liczba > max)
                max = liczba;
        }

        // Wyświetlanie wyników
        Console.WriteLine($"Najmniejsza liczba: {min}");
        Console.WriteLine($"Największa liczba: {max}");

        // Oczekiwanie na wciśnięcie klawisza przed zamknięciem
        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }
}
