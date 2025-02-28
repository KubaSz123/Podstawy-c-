using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to liczba parzysta,
            //czy też nieparzysta
            Int32 a;
            Console.Write("podaj liczbe a=");
            a = Convert.ToInt32(Console.ReadLine());
            if (a%2==0 )
            
                Console.Write("liczba {0} jest parzysta", a);
             else
                    Console.Write("liczba {0} nie parzysta", a);
            
            Console.ReadKey(true);

        }
    }
}
