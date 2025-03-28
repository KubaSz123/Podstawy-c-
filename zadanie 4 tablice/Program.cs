using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4_tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n(1 <= n <= 1000) liczb całkowitych i wypisujący
            //na ekranie sumę wczytanych liczb.

            int [] tab = new int[1000];
            int i;
            int n, suma;
            Console.Write("Podaj ilosc elementow tablciy n<=1000");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab:[{0}]= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            suma = 0;
            for (i = 0; i < n; i++)
            {
                suma = suma + tab[i];
            }
            Console.Write("Suma elementow tablicy: {0}", suma);
            Console.ReadKey(true);


        
        }
    }
}
