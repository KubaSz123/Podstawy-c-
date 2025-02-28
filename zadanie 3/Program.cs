using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        { //Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i największej z tych liczb. 
            double a, b, c;
            Console.Write("Podaj liczbe a");
           a = Convert.ToDouble(Console.ReadLine());
            Console.Write("podaj liczbe b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj licz e c");
            c = Convert.ToDouble(Console.ReadLine());
            if (a > b&& a>c && b>c)
            Console.Write("Liczbą najwieksza jest a={0}, Liczbą najmniejsza jest c={1}", a, c);
            else if (a > b && a > c && c > b)
                Console.WriteLine("Liczbą największa jest a={0}, Liczbą najmniejsza jest b={1}", a, b);
            else if (b > a && c > a && b > c)
                Console.WriteLine("Liczba najwieksza jest b={0}, Liczba najmniejsza jest a={1}", b, a);
            else if (b > a && b > c && a > c)
                Console.WriteLine("Liczba najwieksza jest b={0}, Liczba najmniejsza jest c={1}", b, c);
            else if (c>a && c>b && a>b)
                Console.WriteLine("Liczba najwieksza jest c={0}, Liczba najmniejsza jest b={1}",b,c);
            else if (c > a && b > a && c > b)
                Console.WriteLine("Liczba najwikesza jest c={0}, Liczba najmniejsza jest a={1}",c, a);
            Console.ReadKey(true);




        }
    }
}
