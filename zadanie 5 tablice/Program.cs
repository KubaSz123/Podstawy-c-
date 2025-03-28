using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5_tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie dwójkowym.
            int[] tab = new int[1000];
            int i, n;
            Console.Write("Podaj liczbe naturalna");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; n > 0; i++)
            {
                tab[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Liczba w systemie binarnym: ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write("{0}", tab[i]);
            }
            Console.ReadKey(true);

        }
    }
}
