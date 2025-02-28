using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4
{

    class Program
    {
        static void Main(string[] args)

        {
            //4. Napisać program wczytujący boki prostokąta i wypisujący na ekranie jego pole i obwód. 
            double a, b;
            Console.Write("Podaj a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pole={0}", a * b);
            Console.WriteLine("Obwód={0}", 2*a + 2*b);
            Console.ReadKey(true); //pauza



        }  
    
    }
}
