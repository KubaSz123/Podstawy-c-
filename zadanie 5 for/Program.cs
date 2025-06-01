using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5_for
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
                    for (j = 1; j <= i; j++) // liczba kolumn
                        Console.Write("*");
                    Console.WriteLine(""); // nowa linia
                }
                Console.ReadKey(true); // pauza
            }
        }
    }
}
