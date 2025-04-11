using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class Program
    {
        
        
        // Napisać procedurę (czyli funkcję, która nie zwraca żadnej wartości)  posiadającą trzy 
        // parametry: a - długość boku kwadratu, znak1-znak będący konturem kwadratu, znak2 - znak
          //będący wypełnieniem kwadratu.Procedura ma rysować na ekranie kwadrat o zadanych
         //argumentach.Przetestuj działanie utworzonej procedury.\
         // Procedura rysująca kwadrat (nie zwraca wartości)
    static void kwadrat(int a, char znak1, char znak2)
        {
            int i, j;

            // Pierwsza linia kwadratu (sama ramka)
            for (i = 1; i <= a; i++) Console.Write(znak1);
            Console.WriteLine(); // przejście do nowej linii

            // Środek kwadratu
            for (i = 2; i <= a - 1; i++)
            {
                Console.Write(znak1); // początek linii (ramka)
                for (j = 2; j <= a - 1; j++) Console.Write(znak2); // środek wypełniony
                Console.Write(znak1); // koniec linii (ramka)
                Console.WriteLine(); // przejście do nowej linii
            }

            // Ostatnia linia kwadratu (sama ramka)
            for (i = 1; i <= a; i++) Console.Write(znak1);
        }

        // Testujemy naszą funkcję
        static void Main(string[] args)
        {
            kwadrat(6, '#', '*');
            Console.ReadKey(true); // pauza
        }
    }
    
}
