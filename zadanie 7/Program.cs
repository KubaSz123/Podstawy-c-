using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
           // Napisać program wczytujący dwie liczby całkowite i wypisujący na 
           // kranie iloraz tych liczb z uwzględnieniem części całkowitej i reszty z dzielenia.
            Int32 a, b;
            Console.Write(" podaj a ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}/{1}={2}r{3}", a, b, a/b, a%b);
            Console.ReadKey(true);
        }
    }
}
