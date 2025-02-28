using System;

class Program
{
    static void Main()
    {
        // Wczytywanie pierwszej liczby
        Console.Write("Podaj pierwszą liczbę: ");
        double liczba1 = Convert.ToDouble(Console.ReadLine());

        // Wczytywanie drugiej liczby
        Console.Write("Podaj drugą liczbę: ");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        // Obliczenia
        double suma = liczba1 + liczba2;
        double roznica = liczba1 - liczba2;
        double iloczyn = liczba1 * liczba2;

        // Sprawdzenie czy druga liczba nie jest zerem przed wykonaniem dzielenia
        double iloraz = liczba2 != 0 ? liczba1 / liczba2 : double.NaN;

        // Wyświetlanie wyników
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Różnica: {roznica}");
        Console.WriteLine($"Iloczyn: {iloczyn}");
        Console.WriteLine($"Iloraz: {(liczba2 != 0 ? iloraz.ToString() : "Nie można dzielić przez zero")}");

        // Oczekiwanie na wciśnięcie klawisza przed zamknięciem
        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }
}