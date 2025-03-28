using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3_tablice
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący ciąg n (1<=n<=1000)
         //liczb całkowitych, sortujący je niemalejąco i wypisujący posortowane liczby na ekranie. 
            int[] tab = new int[1000];
            int i, j, n, tmp;
            Console.Write("Podaj ilosc elementow tablciy n<=1000");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab:[{0}]= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (i = 0; i < n - 1; i++)
            {
                for (j = 0; j < n - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        tmp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = tmp;
                    }
                }
            }
            Console.Write("elementy tablicy");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", tab[i]);
            }
            Console.ReadKey(true);




        }
    }
}
