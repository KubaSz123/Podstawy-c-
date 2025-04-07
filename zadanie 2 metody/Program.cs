using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace zadanie_2_metody
{
    //Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych
    //zadanych jako argumenty tej funkcji.Napisz program wykorzystujący funkcję max.
    internal class Program
    {
        static double max(double a, double b)
        { if (a > b)
                return a;
            else return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Maksymalna wartosc z 10 i 24 to {0}", max(10, 24));
            Console.ReadKey(true);
        }
    }
}
