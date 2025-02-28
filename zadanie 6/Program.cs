using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn i
            //iloraz.
            double a, b, suma, różnica, iloczyn, iloraz;
            Console.WriteLine("podaj a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj b=");
            b = Convert.ToDouble(Console.ReadLine());
            suma = a + b;
            różnica = a - b;
            iloczyn = a * b;
            iloraz = a / b;
            Console.WriteLine("{0}+{1}={2}", a, b,suma);
            Console.WriteLine("{0}-{1}={2}", a, b, różnica);
            Console.WriteLine("{0}*{1}={2}", a, b, iloczyn);
            Console.WriteLine("{0}/{1}={2}", a, b, iloraz);
            Console.ReadKey(true); //pauza
        }
    }
}
