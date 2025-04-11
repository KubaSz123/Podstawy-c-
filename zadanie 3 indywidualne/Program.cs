using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3_indywidualne
{
    class Program
    {
        static void Main(string[] args)
        {//Dany jest trójkąt o współrzędnych A=(-4,-4), B=(4,-2), C=(6,6). Wczytaj od użytkownika współrzędne punktu P=(x,y).
         //Wypisz na ekranie informację czy punkt P leży wewnątrz, na zewnątrz, czy też na boku trójkąta ABC. Wskazówka :
         //Wyznacz proste AB, AC i BC oraz sprawdź położenie punktu P względem wyznaczonych prostych
            int x, y;
            Console.WriteLine("Podaj wspolrzedne punktu x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj wspolrzedne punktu y = ");
            y = Convert.ToInt32(Console.ReadLine());
            // Współrzędne punktów A, B, C
            int Ax = -4, Ay = -4;
            int Bx = 4, By = -2;
            int Cx = 6, Cy = 6;
            // Obliczanie wartości funkcji liniowej dla punktu P względem prostych AB, AC i BC
            double AB = (By - Ay) * (x - Ax) - (Bx - Ax) * (y - Ay);
            Console.WriteLine("Wartosc funkcji AB = " + AB);
            double AC = (Cy - Ay) * (x - Ax) - (Cx - Ax) * (y - Ay);
            Console.WriteLine("Wartosc funkcji AC = " + AC);
            double BC = (Cy - By) * (x - Bx) - (Cx - Bx) * (y - By);
            Console.WriteLine("Wartosc funkcji BC = " + BC);
            // Sprawdzanie położenia punktu P względem prostych
            Console.WriteLine("Wspolrzedne punktu P: (" + x + "," + y + ")");
            if (AB == 0 || AC == 0 || BC == 0)
            {
                Console.WriteLine("Punkt P lezy na boku trojkata");
            }
            else if ((AB > 0 && AC > 0 && BC > 0) || (AB < 0 && AC < 0 && BC < 0))
            {
                Console.WriteLine("Punkt P lezy wewnatrz trojkata");
            }
            else
            {
                Console.WriteLine("Punkt P lezy na zewnatrz trojkata");
            }
            Console.ReadKey(true);



        }
    }
}
