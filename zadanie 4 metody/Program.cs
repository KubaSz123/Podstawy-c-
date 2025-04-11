using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4_metody
{
    internal class Program
    // Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej
    // liczby naturalnej jako argument tej funkcji. Napisz program wykorzystujący funkcję ile_cyfr. 

    {
        static int Ile_cyfr(int liczba)
        {
            int i = 0;
            while (liczba / 10 > 0)
            {
                liczba /= 10;
                i++;
            }
            return i + 1 ;
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Liczba 21 ma {0} cyfr: ", Ile_cyfr(21));
            Console.WriteLine("liczba 1234 ma {0} cyfr",Ile_cyfr(1234));
            Console.ReadKey(true);
        }
    }
}
