using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_7__while_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program obliczający wartość n! (n silnia, n!=1*2*…*n)
            //dla wczytanej z klawiatury liczby naturalnej n. Użyj pętli while. Np.: dla n=5 wypisz wynik 5!=120. 
            int n;
            int i = 1;
            int silnia = 1;
            Console.Write("Podaj n = ");
            n = Convert.ToInt32(Console.ReadLine());
            while (i <= n)
            {
                silnia *= i;
                i++;
            }
            Console.WriteLine("{0}! = {1}", n, silnia);
            Console.ReadKey(true);
            
        }
    }
}
