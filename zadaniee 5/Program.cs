using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaniee_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący promień podstawy (r) i wysokość (h)
            // stożka i wypisujący na ekranie objętość i pole całkowite tego stożka. 
            Double r, h, l, V, Pc;
            Console.Write("Podaj promień") ;
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj wysokość");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(r * r + h * h);
            V = 1.0 / 3 * Math.PI * r * r * h;
            Pc = Math.PI * r * r + Math.PI * r * 1;
            Console.WriteLine("objętość={0}", V);
            Console.WriteLine("Pole={0}", Pc);
            Console.ReadKey (true);
        }
    }
}
