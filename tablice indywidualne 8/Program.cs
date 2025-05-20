using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice_indywidualne_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n (1<=n<=1000) liczb naturalnych i wypisujący na ekranie
            //wszystkie parzyste liczby w kolejności niemalejącej. Do wypisywania elementów tablicy użyj pętli foreach.
            //Wskazówka: Posortuj wczytane liczby, a następnie z tablicy wypisz tylko liczby parzyste. 

            int[] tab = new int[1000];
            int i, j;
            int n, tmp;
            Console.Write("Podaj liczbe elementow tablicy n<=1000");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj wartosc tab[{0}]=", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (i = 0; i < n; i++)
                for (j = i + 1; j < n; j++)
                    if (tab[i] > tab[j])
                    { tmp = tab[i]; tab[i] = tab[j]; tab[j] = tmp; }

            Console.WriteLine("Liczby parzyste tablicy (niemalejąco):");
            foreach (int liczba in tab)
            {
                if (liczba % 2 == 0)
                    Console.Write("{0} ", liczba);
            }
        }
    }
}