using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1_tablice_2_sposob
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n (1<=n<=1000)
            //liczb całkowitych (dodatnich i ujemnych) i wypisujący wczytane liczby na ekranie
            int[] tab = new int[1000];
            int i, n;
            do
            {
                Console.Write("Podaj ilosc elementow tablicy n<=1000: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1 || n > 1000);
            tab = new int[n];
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Elementy tablicy: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", tab[i]);
            }
            Console.ReadKey(true);

        }
    }
}
