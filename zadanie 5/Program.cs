using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący promień podstawy (r) i wysokość (h) stożka i wypisujący na 
            // ekranie objętość i pole całkowite tego stożka.
            double r, h, l, v, Pc;
            Console.WriteLine("podaj r=");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj h=");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(r * r + h * h); //definiujemy tworząca
            v = 1.0 / 3 * Math.PI * r * r * h; //def objetosc
            Pc = Math.PI * r * r * l * Math.PI * r; // def pc
            Console.WriteLine("objetość={0}", v);
            Console.WriteLine("Pole całkowite={0}", Pc);
            Console.ReadKey(true); //pauza
        }
    }
}
