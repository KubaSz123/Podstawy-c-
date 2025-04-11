using System;

class Program
{
    // Procedura rysująca kwadrat
    static void RysujKwadrat(int a, char znak1, char znak2)
    {
        int i, j;

        // Rysowanie pierwszej (górnej) linii - kontur
        for (i = 1; i <= a; i++)
            Console.Write(znak1);
        Console.WriteLine();

        // Rysowanie środka kwadratu - kontur + wypełnienie
        for (i = 2; i <= a - 1; i++)
        {
            Console.Write(znak1); // lewa krawędź
            for (j = 2; j <= a - 1; j++)
                Console.Write(znak2); // wnętrze
            Console.Write(znak1); // prawa krawędź
            Console.WriteLine();
        }

        // Rysowanie ostatniej (dolnej) linii - kontur
        for (i = 1; i <= a; i++)
            Console.Write(znak1);
        Console.WriteLine();
    }

    // Funkcja główna testująca procedurę
    static void Main(string[] args)
    {
        // Przykład użycia: kwadrat o boku 6, kontur: #, wypełnienie: *
        RysujKwadrat(6, '#', '*');

        Console.ReadKey(); // pauza na końcu
    }
}
