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
                /*
               int liczba = 20; // ZADANIE 11.6, wariant A na petli for
               int wykladnik = 20;
               for (int i=1;i<=20;i++)
               {
                   for (int j=liczba;j>=1;j--)
                   {
                       if (i == 20)
                       {
                           Console.WriteLine("20");
                           continue; 
                       }
                       Console.Write(wykladnik--+" ");
                   }
                   liczba--;
                   wykladnik = liczba;
                   Console.WriteLine();
               } */
               /*
            int liczba = 20; // WARIANT {B} / na petli while
            int wykladnik = 20;
            while (liczba > 0)
            {
                Console.Write(wykladnik + " ");
                if (wykladnik == 1)
                {
                    Console.WriteLine();
                    wykladnik = liczba;
                    liczba--;

                }
                if (liczba == 0)
                {
                    Console.WriteLine("20");
                }
                wykladnik--;
            } */

            Console.ReadKey();
        }
    }
}
