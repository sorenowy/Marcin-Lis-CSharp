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
                
            } */ // ZADANIE 11.3
                 /*
                 int liczba = -100; 
                 while (liczba <= 100)
                 {
                     if (liczba % 4 == 0)
                     {
                         if (liczba % 8 != 0)
                         {
                             if (liczba % 10 != 0)
                             {
                                 Console.WriteLine($"Liczba {liczba} jest podzielna przez 4 ale nie podzielna przez 8 i 10");
                                 liczba++;
                             }
                             else
                                 liczba++;
                             continue;
                         }
                         else
                         liczba++;
                         continue;
                     }
                     else
                     liczba++;
                     continue;
                 } */ // ZADANIE 11.4

            /* 
            for (int i=1;i<=20;i++)
            {
                if (i % 2 == 0)
                Console.Write("{0} ", i);
            }
             */ // ZADANIE 11.5
            
            for (int i = 20; i >= 1; i--)
            {
                int liczba = 20;
                for (int j = 20; j >= 1; j--)
                {
                    for (int z =20;z>=1;z--)
                    {
                        Console.Write(liczba + " ");
                    }
                    Console.WriteLine();
                    liczba--;
                }
                if (i == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("20");
                }                    
                else
                    Console.WriteLine(); 
            }
            Console.ReadKey();
        }
    }
}
