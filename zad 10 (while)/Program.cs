using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_10__while_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program sumujący kolejne liczby całkowite podawane przez użytkownika, aż do napotkania zera.
            //Wypisz otrzymaną sumę na ekranie. Użyj pętli do-while. 
            int liczba;
            int suma = 0;
            do
            {
                Console.Write("Podaj liczbe = ");
                liczba = Convert.ToInt32(Console.ReadLine());
                suma += liczba;
            } while (liczba != 0);
            Console.WriteLine("Suma liczb wynosi {0}", suma);
            Console.ReadKey(true);


        }
    }
}
