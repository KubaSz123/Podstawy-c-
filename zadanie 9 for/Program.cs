using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_9_for
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int i, j;
                for (i = 1; i <= 10; i++) // wiersze
                {
                    for (j = 1; j <= 10; j++) // kolumny
                        Console.Write("{0,3} ", i * j); // wiersz * kolumna
                    Console.WriteLine("");
                }
                Console.ReadKey(true); // pauza
            }
            }
    }
}
