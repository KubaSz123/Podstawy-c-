using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_5__while_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            do
            {
                Console.Write("Podaj * = ");
                x = Convert.ToDouble(Console.ReadLine());
            } while (x <= 0);
            Console.WriteLine("Wczytano liczbe x = {0}", x);
            Console.ReadKey(true);

        }
    }
}
