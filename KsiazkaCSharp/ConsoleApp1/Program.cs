using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*class Tablica
    {
        private int[] tablica = new int[10];
        private bool _blad = false;
        public bool WystapilBlad
        {
            get
            {
                return _blad;
            }
        }
        public int pobierzElement(int index)
        {
            if (index >= tablica.Length || index < 0)
            {
                _blad = true;
                return 0;
            }
            else
            {
                _blad = false;
                return tablica[index];
            }
        }
        public void ustawElement(int index, int wartosc)
        {
            if (index >= tablica.Length || index < 0)
            {
                _blad = true;

            }
            else
            {
                tablica[index] = wartosc;
                _blad = false;
            }
            try
            {
                index >= tablica.Length;
            }
            catch(ArgumentOutOfRangeException e)
            {

            }
        }
    } */
    class Tablica
    {
        private int[] tablica = new int[10]; // Zadanie 21.1-2
        private bool _blad = false;
        public bool WystapienieBledu
        {
            get
            {
                return _blad;
            }
        }
        public void Testuj(int index, int wartosc)
        {
            try
            {
                tablica[index] = wartosc;
                Console.WriteLine($"Tablica nr. {index} wynosi {wartosc}");
                _blad = true;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                _blad = false;
            }
            catch (IndexOutOfRangeException)
            {
                if (index < 0)
                {
                    Console.WriteLine("Argument jest mniejszy od zadeklarowanego rozmiaru tablicy");
                    _blad = false;
                }
                else if (index >= tablica.Length)
                {
                    Console.WriteLine("Argument jest wiekszy od zadeklarowanego rozmiaru tablicy");
                    _blad = false;
                }
            }
            catch (ArgumentOutOfRangeException f)
            {
                Console.WriteLine(f.Message);
                _blad = false;
            }
        }

    }
    class Example // Zadanie 21.5
    {
        private int[] tablica = new int[10];

        private int a()
        {
            return -1;
        }
        public void b(int index, int wartosc)
        {
            try
            {
                tablica[index] = wartosc;
                a();
                Console.WriteLine("Została wywołana metoda a i b");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Tablica t1 = new Tablica(); // Zadanie 21.4
            t1.Testuj(5, 4);
            if (t1.WystapienieBledu == true) // Zadanie 21.3
            {
                Console.WriteLine("Metoda została wywołana poprawnie");
            }
            else
            {
                Console.WriteLine("Metoda nie została wywołana");
            } */
            
            try
            {
                int a, b;
                Example e1 = new Example();
                Console.WriteLine("Podaj wartość dla pierwszej tablicy");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                e1.b(a, b);
                Console.WriteLine("Podaj wartosc dla drugiej tablicy");
                Example e2 = new Example();
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                e2.b(a,b);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("wez cos kurwa wpisz");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Pomyłka za duzo213");
            }
            catch(FormatException)
            {
                Console.WriteLine("Zjebałeś format chujcu");
            }
            Console.ReadKey();
        }
    }
}
