using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1_indywidualne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący współrzędne punktu P=(x,y) i wypisujący na ekranie informację, do której
            //ćwiartki ten punkt należy, czy też informację, że leży on na osi OX i/lub osi OY. 
            int x, y;
            Console.WriteLine("Podaj wspolrzedne punktu x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj wspolrzedne punktu y = ");
            y = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0)
            { Console.WriteLine("Punkt nalezy to 1 cwiartki"); }
            else if (x < 0 && y > 0)
            { Console.WriteLine("Punkt nalezy do 2 cwiarki"); }
            else if (x < 0 && y < 0)
            { Console.WriteLine("Punkt nalezy do 3 cwiartki"); }
            else if (x > 0 && y < 0)
            { Console.WriteLine("Punkt nalezy do 4 cwiartki"); }
           else if ( x == 0 && y != 0 )
            { Console.WriteLine("Punkt lezy na osi OY"); }
            else if (x != 0 && y == 0)
            { Console.WriteLine("Punkt lezy na osi OX"); }
            else if (x == 0 && y == 0)
           
            Console.ReadKey(true);

        }
    }
}
