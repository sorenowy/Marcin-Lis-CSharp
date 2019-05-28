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
            /*
            Console.WriteLine("Podaj cyfre od 0 do 10");
            int liczba = int.Parse(Console.ReadLine());
            switch (liczba)
            {
                case 0:
                    Console.WriteLine("Liczba to 0");
                    break;
                case 1:
                    Console.WriteLine("Liczba to 1");
                    break;
                case 2:
                    Console.WriteLine("Liczba to 2");
                    break;
                case 3:
                    Console.WriteLine("Liczba to 3");
                    break;
                case 4:
                    Console.WriteLine("Liczba to 4");
                    break;
                case 5:
                    Console.WriteLine("Liczba to 5");
                    break;
                case 6:
                    Console.WriteLine("Liczba to 6");
                    break;
                case 7:
                    Console.WriteLine("Liczba to 7");
                    break;
                case 8:
                    Console.WriteLine("Liczba to 8");
                    break;
                case 9:
                    Console.WriteLine("Liczba to 9");
                    break;
                case 10:
                    Console.WriteLine("Liczba to 10");
                    break;
                default:
                    Console.WriteLine("Liczba przekracza wartosc od 1 do 10");
                    break;
            }
            Console.ReadKey(); */                                                                       // Zadanie 9.1

            /*
            Console.WriteLine("Podaj wartosc pierwszej liczby w działaniu");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wartosc drugiej liczby w działaniu");
            int liczba2 = int.Parse(Console.ReadLine());
            int wynik = liczba1 % liczba2;
            bool sprawdzenie = true;
            sprawdzenie = (wynik == 0);
            Console.WriteLine($"Reszta z działania : {liczba1} % {liczba2} wynosi {wynik}");
            switch (sprawdzenie)
            {
                case true:
                    Console.WriteLine("Działanie jest prawdziwe! Boolean = {0}", sprawdzenie);
                    break;
                default:
                    Console.WriteLine("Działanie jest nieprawdziwe! Boolean = {0}", sprawdzenie);
                    break;
            }
            Console.ReadKey(); */                                                                       // Zadanie 9.2

            /*
            Console.WriteLine("Podaj liczbę w celu obliczenia wartosci bezwzględnej");
            int liczba = int.Parse(Console.ReadLine());
            int liczbawar = (liczba > 0) ? liczba : -liczba;
            Console.WriteLine("Liczba {0} jest wartością bezwzględną liczby {1}", liczbawar, liczba);
            Console.ReadKey(); */                                                                       // Zadanie 9.3

            /*
            int liczba1 = 10;
            int liczba2;
            if (liczba1 < 0)
                liczba2 = -1;
            else
                liczba2 = 1;
            Console.WriteLine("liczba2 wynosi:{0}",liczba2);
            Console.WriteLine();
            Console.ReadKey(); */                                                                      // Zadanie 9.4

            /*
            Console.WriteLine("Podaj liczbę w celu sprawdzenia:");
            int liczba = int.Parse(Console.ReadLine());
            switch (liczba)
            {
                case 1:
                    Console.WriteLine("Liczba ma wartość {0} i nalezy do grupy 1", liczba);
                    break;
                case 2:
                    Console.WriteLine("Liczba ma wartość {0} i nalezy do grupy 2", liczba);
                    break;
                case 3:
                    goto case 2;
                case 4:
                    goto case 1;
                case 7:
                    goto case 2;
                case 8:
                    goto case 1;
                default:
                    Console.WriteLine("Liczba {0} wykracza poza zakres", liczba);
                    break;
            }
            Console.ReadKey();
            */                                                                                          // Zadanie 9.5
        }
    }
}
