using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4_indywidualne
{
    class Program
    {
        static void Main(string[] args)
        {// Napisać program wczytujący kwotę w złotych, a następnie
         // przeliczający ją na taką walutę jaką wybierze użytkownik: funty, dolary, euro. Użyj instrukcji switch.
            double kwotaPLN;
            Console.WriteLine("Podaj kwota w złotych");
           kwotaPLN = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("wybierz walute do przeliczenia:");
            Console.WriteLine("1-euro");
            Console.WriteLine("2-dolary");
            Console.WriteLine("3-funty");
            double kursEuro = 4.6;
            double kursDolary = 4.2;
                double kursFunty = 5.3;
            double wynik;
            int wybor = Convert.ToInt32(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    wynik = kwotaPLN / kursEuro;
                    Console.WriteLine("Kwota w euro: " + wynik);
                    break;
                case 2:
                    wynik = kwotaPLN / kursDolary;
                    Console.WriteLine("Kwota w dolarach: " + wynik);
                    break;
                case 3:
                    wynik = kwotaPLN / kursFunty;
                    Console.WriteLine("Kwota w funtach: " + wynik);
                    break;
                default:
                    Console.WriteLine("Niepoprawny wybor");
                    break;
            }
            Console.ReadKey(true);






        }
    }
}
