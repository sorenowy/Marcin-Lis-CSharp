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
            /* for (int i=1;i<=10;i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine("Liczba {0} jest podzielna przez 2", i);
                }
            }
            Console.ReadKey(); */ // Zadanie 10.1

            /* int a = 0;
            while (a++ < 10)
            {
                Console.WriteLine("{0} Petle w c#",a-1);
            }
            Console.ReadKey(); */ // Zadanie 10.2

            /* int i = 1;
             while (i<=20)
             {
                 if (i % 3 == 0)
                 {
                     Console.WriteLine($"Liczba {i} jest podzielna przez 3:");
                 }
                 i++;
             }
             Console.WriteLine("Program zakonczył pracę, wcisnij klawisz aby zamknąć okno");
             Console.ReadKey(); */ // Zadanie 10.3

            /* int i = 0;
            do
            {
                Console.WriteLine(" i= {0}. Pętle w C#", i);
                i++;
            }
            while (i <= 9);
            Console.ReadKey(); */ // Zadanie 10.4

            /* for (int i=1;i<=20;i++) // WARIANT (A)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"Liczba {i} jest parzysta");
                else if (i% 2 == 1)
                        Console.WriteLine($"Liczba {i} nie jest parzysta");
            }
            Console.ReadKey(); */
            /*
            int liczba = 1; // WARIANT {B}
            while (liczba <= 20)
            {
                if (liczba % 2 == 0)
                    Console.WriteLine($"Liczba {liczba} jest parzysta");
                else if (liczba % 2 == 1)
                    Console.WriteLine($"Liczba {liczba} nie jest parzysta");
                liczba++;
            }
            Console.ReadKey(); */
            /*
            int liczba = 1; // WARIANT {C}
            do
            {
                if (liczba % 2 == 0)
                    Console.WriteLine($"Liczba {liczba} jest parzysta");
                else if (liczba % 2 == 1)
                    Console.WriteLine($"Liczba {liczba} nie jest parzysta");
                liczba++;
            }
            while (liczba <= 20);
            Console.ReadKey(); */ // Zadanie 10.5

            /*
            for (int i = 100; i >= 1; i--) // WARIANT {A}
            {
                if (i % 3 == 0)
                {
                    if (i % 2 == 1)
                        Console.WriteLine("Liczba {0} jest podzielna przez 3 ale nie podzielna przez 2",i);
                }
            }
            Console.ReadKey(); */
            /*
            int liczba = 100; // WARIANT {B}
            while (liczba >= 1)
            {
                if (liczba % 3 == 0)
                {
                    if (liczba % 2 == 1)
                        Console.WriteLine("Liczba {0} jest podzielna przez 3 ale nie podzielna przez 2", liczba);
                }
                liczba--;
            }
            Console.ReadKey(); */

            int liczba = 100;
            do
            {
                if (liczba % 3 == 0)
                {
                    if (liczba % 2 == 1)
                        Console.WriteLine("Liczba {0} jest podzielna przez 3 ale nie podzielna przez 2", liczba);
                }
                liczba--;
            }
            while (liczba >= 1);
            Console.ReadKey(); // ZADANIE 10.6
        }
    }
}
