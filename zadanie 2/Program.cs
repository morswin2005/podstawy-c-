using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class Program
    {
        
        
            //Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja 
           // powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb.Przetestuj działanie
           //utworzonej funkcji.
           
     // Funkcja sprawdza, czy jej argument jest liczbą pierwszą
    static int czy_pierwsza(int liczba)
        {
            int i;
            for (i = 2; i < liczba / 2; i++)
            {
                if (liczba % i == 0) return 0; // liczba nie jest pierwsza
            }
            return 1; // liczba musi być pierwsza
        }

        // Testujemy naszą funkcję
        static void Main(string[] args)
        {
            Console.WriteLine("Czy 12 jest l. pierwszą: {0}", czy_pierwsza(12));
            Console.WriteLine("Czy 13 jest l. pierwszą: {0}", czy_pierwsza(13));
            Console.ReadKey(true); // pauza
        }



    }
    
}
