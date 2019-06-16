using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Punkt
    {
        public int x;
    }
    class Program
    {
        static void Ukladanka()
        {
            int wartosc, liczba2;
            string zbior = string.Empty;
            try
            {
                Console.WriteLine("Podaj wartosci dla pierwszego sprawdzenia:"); // ZADANIE 22.5
                try
                {
                    wartosc = int.Parse(Console.ReadLine());
                    liczba2 = int.Parse(Console.ReadLine());
                    wartosc /= liczba2;
                    Console.WriteLine(wartosc);
                }
                catch(DivideByZeroException f)
                {
                    Console.WriteLine("nie można podzielić przez 0!");
                    Console.WriteLine(f.ToString());
                    zbior = string.Concat(f);
                    wartosc = 10;
                }
                Console.WriteLine("podaj wartosc dla drugiego sprawdzenia:");
                wartosc = int.Parse(Console.ReadLine());
            }
            catch (SystemException e)
            {
                Console.WriteLine("Wystapił błąd znaków:");
                Console.WriteLine(e.ToString());
                zbior = String.Concat(zbior,e);
            }
            finally
            {
                Console.Clear();
                Console.Write("Zbior zawiera:");
                Console.WriteLine(zbior);
            }
        }
        static void Main(string[] args)
        {
            /*Punkt punkt = null;
            int liczba1 = 10, liczba2 = 0, i = 0;
            while (i < 2)
            {
                try
                {
                    /*try // ZADANIE 22.1 i 22.2
                    {
                        liczba1 /= liczba2;
                    }
                      catch (ArithmeticException d)
                    {
                        Console.WriteLine("nastąpił błąd arytmetyczny w programie:");
                        Console.WriteLine(d.ToString());
                        Console.WriteLine();
                        Console.WriteLine("Przypisuje liczbie 1 wartość 10;");
                        Console.WriteLine();
                        liczba1 = 10;
                    } */
            /*punkt.x = liczba1; // ZADANIE 23.4
            liczba1 /= liczba2;

        }
        catch (ArithmeticException d)
        {
            Console.WriteLine("nastąpił błąd arytmetyczny w programie:");
            Console.WriteLine(d.ToString());
            Console.WriteLine("Przypisuje liczbie 1 wartość 10;");
            Console.WriteLine();
            liczba1 = 10;
            liczba2 = 5;
        }
        /* try // ZADANIE 21.3
        {
            punkt.x = liczba1;
        }
        catch (NullReferenceException h)
        {
            Console.WriteLine("Nastapil błąd odwołania do pustego");
            Console.WriteLine(h.ToString());
            Console.WriteLine("Nastepuje poprawka przypisania do punktu!");
            punkt = new Punkt();
        } */
            /*catch (SystemException f)
            {
                Console.WriteLine("Błąd ogólny:");
                Console.WriteLine(f.ToString());
                Console.WriteLine("program ustawi prawidłową inicjalizację obiektu");
                punkt = new Punkt();
                Console.WriteLine();
            }
            i++; 
        }*/
            Ukladanka();
            Console.ReadKey();
        }
        
    }
}
