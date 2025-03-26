using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_6__while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int wybor;
            double a, b;
            Console.WriteLine("MENU");
            Console.WriteLine("1 - Oblicz pole prostokąta");
            Console.WriteLine("2 - Oblicz pole kwadratu");
            Console.WriteLine("3 - Oblicz pole trójkąta");
            Console.WriteLine("0 - koniec");
            Console.Write("twoj wybor");
            wybor = Convert.ToInt32(Console.ReadLine());
            switch (wybor)
            {
                case 0:
                    break;
                case 1:
                    Console.Write("podaj a = ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("podaj b");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("pole prostokąta wynosi {0}", a * b);
                    break;
                case 2:
                    Console.Write("podaj a = ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("pole kwadratu wynosi {0}", a * a);
                    break;
                case 3:
                    Console.Write("podaj a = ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("podaj h = ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("pole trójkąta wynosi {0}", 0.5 * a * b);
                    break;
                default:
                    Console.WriteLine("błędny wybór");
                    break;
                        


            }

        }
    }
}
