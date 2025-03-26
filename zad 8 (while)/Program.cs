using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_8__while_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz program stwierdzający, czy zadana liczba n jest pierwsza. Użyj pętli while.
            int n;
            int i = 2;
            bool pierwsza = true;
            Console.Write("Podaj n = ");
            n = Convert.ToInt32(Console.ReadLine());
            while (i < n)
            {
                if (n % i == 0)
                {
                    pierwsza = false;
                    break;
                }
                i++;
            }
            if (pierwsza)
            {
                Console.WriteLine("{0} jest liczbą pierwszą", n);
            }
            else
            {
                Console.WriteLine("{0} nie jest liczbą pierwszą", n);
            }
            Console.ReadKey(true);
        }
    }
}
