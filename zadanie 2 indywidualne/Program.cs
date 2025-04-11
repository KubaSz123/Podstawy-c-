using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2_indywidualne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący współrzędne dwóch punktów A=(x1,y1) i
            //B=(x2,y2) oraz wypisujący na ekranie wzór funkcji liniowej przechodzącej przez te dwa punkty.
            //Wskazówka: Równanie prostej przechodzącej przez dwa punkty:
            int x1, y1, x2, y2;
            Console.WriteLine("Podaj współrzędną x1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj współrzędną y1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj współrzędną x2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj współrzędną y2");
            y2 = Convert.ToInt32(Console.ReadLine());
            if (x1 == x2 && y1 == y2)
            {
                Console.WriteLine("Punkty A i B są identyczne — nie można wyznaczyć jednej prostej.");
            }
            else if (x1 == x2)
            {
                Console.WriteLine("Prosta pionowa: x = {x1}");
            }
            else if (y1 == y2)
            {
                Console.WriteLine("Prosta pozioma: y = {y1}");
            }
            else
            {
                // Wypisujemy wzór dokładnie według wzoru matematycznego
                Console.WriteLine("Równanie prostej przechodzącej przez punkty A i B:");
                Console.WriteLine($"(y - {y1}) * ({x2} - {x1}) = (x - {x1}) * ({y2} - {y1})");
            }
        }
    }
}







       