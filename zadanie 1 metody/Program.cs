using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1_metody
{
    internal class Program
    {
        static int suma(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami
            // całkowitymi.Napisz program wykorzystujący funkcję suma.
            Console.WriteLine("2+5={0}",suma(2,5));
            Console.ReadKey(true);




        }
    }
    }

