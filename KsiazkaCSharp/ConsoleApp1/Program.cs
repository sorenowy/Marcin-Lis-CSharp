using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program // Zadania z Break i Continue (Petle)
    {
        static void Main(string[] args)
        {
            /* for (int i=1;i<=20;i++) 
             {
                 if (i % 2 == 0)
                     continue;
                 else
                     Console.WriteLine("Liczba {0} jest nieparzysta", i);
             } */ // Zadanie 11.1

            /* int liczba = 0;
             while(liczba++<=20)
             {
                 if (liczba % 2 == 0)
                     continue;
                 else
                     Console.WriteLine("Liczba {0} jest nieparzysta", liczba); // Zadanie 11.2

             } */

            /*
            int liczba = 100; // WARIANT {A}
            while (liczba >= 1)
            {
                if (liczba % 4 == 1)
                {
                    if (liczba % 3 == 1)
                        Console.WriteLine($"Liczba {liczba} jest niepodzielna przez 3 i 4");
                }
                liczba--;
            } */

            /*
            int liczba = 100; // WARIANT {B}
            while (liczba >= 1)
            {
                if (liczba % 4 == 1)
                {
                    if (liczba % 3 == 1)
                        Console.WriteLine($"Liczba {liczba} jest niepodzielna przez 3 i 4");
                    liczba--;
                }
                else
                    liczba--;
                    continue;
                
            } */ // ZADANIE 10.3
            int liczba = -100;
            while (liczba <= 100)
            {
                if(liczba
            }
            Console.ReadKey();
        }
    }
}
