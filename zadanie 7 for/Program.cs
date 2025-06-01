using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7_for
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int i;
                for (i = 13; i <= 100; i += 13)
                    Console.Write("{0}, ", i);
                Console.ReadKey(true); // pauza
            }
        }
    }
}
