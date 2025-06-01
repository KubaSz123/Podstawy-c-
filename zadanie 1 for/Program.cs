using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1_for
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int i;
                for (i = 11; i <= 33; i++)
                    Console.Write("{0}, ", i);
                Console.ReadKey(true); // pauza
            }
        }
    }
}
