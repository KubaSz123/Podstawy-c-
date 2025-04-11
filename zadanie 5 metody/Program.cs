using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5_metody
{
    class Program
    {
        //Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja powinna zwracać 1
        //dla liczb pierwszych i 0 dla pozostałych liczb. Przetestuj działanie utworzonej funkcji. 
        static int liczba_pierwsza(int liczba)
        {
            int i;
            for (i = 2; i < liczba / 2; i++) ;
            if (liczba % i == 0) return 0;
            return 1;

        }

            static void Main(string[] args)
            {
                Console.WriteLine("Czy 7 jest liczbą pierwszą: {0}", liczba_pierwsza(7));
                Console.WriteLine("Czy 12 jest liczbą pierwszą: {0}", liczba_pierwsza(12));

                Console.ReadKey(true);
            }

        }
    }
