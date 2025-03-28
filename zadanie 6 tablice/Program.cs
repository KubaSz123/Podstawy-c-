using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_6_tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadeklaruj tablicę zawierającą nazwy dni tygodnia. Wypisz elementy tablicy za pomocą pętli foreach.
            string[] tab = new string[7] { "poniedzialek", "wtorek", "sroda", "czwartek", "piatek", "sobota", "niedziela" };
            foreach (string element in tab)
            {
                Console.WriteLine(element);
            }
            Console.ReadKey(true);

        }
    }
}
