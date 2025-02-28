using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Napisać program wczytujący liczbę całkowitą i wypisujący informację,
            //czy wczytana liczba jest dodatnia, ujemna, czy też równa zero.
            int a;
            Console.WriteLine("Podaj liczbe a= ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("Liczba dodatnia");
            if (a < 0)
                Console.WriteLine("liczba ujemna");
            if (a == 0)
                Console.WriteLine("Liczba jest równa zero");
            Console.ReadKey(true);
        }
    }
}
