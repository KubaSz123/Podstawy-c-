using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3_for
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n, i, suma = 0;
                Console.Write("Podaj n = ");
                n = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= n; i++)
                    suma += i;
                Console.WriteLine("1+...+{0} = {1}", n, suma);
                Console.ReadKey(true); // pauza
            }
        }
    }
}
