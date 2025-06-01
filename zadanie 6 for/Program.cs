using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_6_for
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int i, j, n;
                Console.Write("Podaj liczbę naturalną n > 1: ");
                n = Convert.ToInt32(Console.ReadLine());

                for (i = 1; i <= n; i++) // liczba wierszy
                {
                    for (j = 1; j <= n - i; j++) Console.Write(" "); // spacje
                    for (j = 1; j <= 2 * i - 1; j++) Console.Write("*"); // gwiazdki
                    Console.WriteLine(""); // nowa linia
                }
                Console.ReadKey(true); // pauza
            }
        }
    }
}
