using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 55, b = 44;
            if (a % b == 0)
                Console.WriteLine($"Dzielenie {a} przez {b} daje reszte 0");
            else
                Console.WriteLine($"Dzielenie {a} przez {b} nie daje reszty 0");
            Console.ReadKey();  // Zadanie 8.1

            int delta;
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            delta = (b * b) - (4 * a * c);
            if (delta > 0)
                Console.WriteLine($"Delta {delta} znajduje sie w zbiorze liczb rzeczywistych");
            else
                Console.WriteLine($"Delta {delta} nie znajduje sie w zbiorze liczb rzeczywistych");
            Console.ReadKey();  // Zadanie 8.2

            Console.WriteLine("Podaj liczbę w celu obliczenia wartosci bezwzglednej");
            int liczba = int.Parse(Console.ReadLine());
            if (liczba < 0)
            {
                int liczbazw = -liczba;
                Console.WriteLine($"Liczba {liczbazw} jest wartoscia bezwzgledna liczby {liczba}");
            }
            else
                Console.WriteLine("Liczba {0} jest wartoscia bezwzgledna liczby {1}", liczba, liczba);
            Console.ReadKey(); */ // Zadanie 8.3

            /*
            Console.WriteLine("Podaj dlugosc prostokata");
            int dl = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj szerokosc prostokata");
            int sz = int.Parse(Console.ReadLine());
            Console.WriteLine($"Prostokat posiada wymiary {dl} na {sz}");
            Console.WriteLine("Podaj punkt a prostokata w celu sprawdzenia");
            int a = int.Parse(Console.ReadLine());
            if (a == 0)
                Console.WriteLine("Punkt a znajduje sie w prostokacie");
            else if (a <= dl)
            {
                if (a <= sz)
                    Console.WriteLine("punkt a znajduje sie w prostokacie");
                else
                    Console.WriteLine("punkt a nie znajduej sie w prostokacie");
            }
            else
                Console.WriteLine("Punkt a nie znajduje sie w prostokacie");
            Console.ReadKey(); */ // Zadanie 8.5                                                    // DO POPRAWIENIA NA ax/ay/bx/by

            /*
            Console.WriteLine("Podaj dlugosc boku kwadratu");
            int dl = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj dlugosc promienia koła");
            int r = int.Parse(Console.ReadLine());
            if (0.5 * dl <= r) // Ze wzoru R=1/2a
                Console.WriteLine("Kwadrat miesci sie wewnatrz koła");
            else
                Console.WriteLine("Kwadrat nie miesci sie wewnatrz koła");
            Console.ReadKey(); */ // Zadanie 8.6
        }
    }
}
