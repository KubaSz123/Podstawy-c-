using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4__while_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int n, k, i, j;

                Console.Write("Podaj n = ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Podaj k = ");
                k = Convert.ToInt32(Console.ReadLine());

                i = 1;
                while (i <= n) // liczba wierszy
                {
                    j = 1;
                    while (j <= k) // liczba kolumn (gwiazdek)
                    {
                        Console.Write("*");
                        j++;
                    }

                    Console.WriteLine(""); // nowa linia
                    i++;
                }
                Console.ReadKey(true); // pauza
            }
            }
    }
}
