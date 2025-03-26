using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_9__while_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program obliczający sumę cyfr dla wczytanej z klawiatury liczby naturalnej.
            //Użyj pętli while. Np.: Dla liczby=1342 trzeba obliczyć sumę 1+3+4+2. 
            int liczba;
            int suma = 0;
            Console.Write("Podaj liczbe = ");
            liczba = Convert.ToInt32(Console.ReadLine());
            while (liczba > 0)
            {
                suma += liczba % 10;
                liczba /= 10;
            }
            Console.WriteLine("Suma cyfr wynosi {0}", suma);
            Console.ReadKey(true);
        }
    }
}
