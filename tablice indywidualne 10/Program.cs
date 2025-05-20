using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice_indywidualne_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych
            // i wypisujący na ekranie informację ile liczb jest dodatnich, ujemnych i równych zero. 
            int[] tab = new int[1000];
            int i, n;
            int dodatnie = 0, ujemne = 0, zera = 0; 

            Console.Write("Podaj ilosc liczb w ciagu n");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]=", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());


                if (tab[i] > 0)
                    dodatnie++;
                else if (tab[i] < 0)
                    ujemne++;
                else
                    zera++;
            }
            Console.WriteLine("Liczb dodatnich: {0}", dodatnie);
            Console.WriteLine("Liczb ujemnych: {0}", ujemne);
            Console.WriteLine("Liczb równych zero: {0}", zera);

        }
    }
}
