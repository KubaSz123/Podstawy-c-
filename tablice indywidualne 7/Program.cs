using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice_indywidualne_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n (1<=n<=1000)
            //liczb całkowitych i wypisujący na ekranie najmniejszą i największą wczytaną liczbę. 
            int[] tab = new int[1000];
            int i, n;
            int min, max;
            Console.Write("Podaj ilosc elementow n w ciagu");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++) 
            {
                Console.Write("Podaj tab[{0}]=", i);    
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            min = tab[0];
            max = tab[0];
            for
                (i = 1; i < n; i++) ;
            if (tab[i] < min)
                min = tab[i];
            if (tab[i] > max)
                max = tab[i];
            Console.WriteLine("Najmniejsza liczba: {0}", min);
            Console.WriteLine("Największa liczba: {0}", max);
        }
    }
}
