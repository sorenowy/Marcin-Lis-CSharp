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
    class Program
    {
        static void Main(string[] args)
        {
            int index, wartosc;
            Tablica t1 = new Tablica();
            Tablica t2 = new Tablica();
            Tablica t3 = new Tablica();
            Console.WriteLine("podaj wartosc dla pierwszej tablicy");
            Console.WriteLine("którą tablicę chcesz wypelnic?");
            t1.Testuj(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine(t1.WystapienieBledu);
            t2.Testuj(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine(t2.WystapienieBledu);
            t3.Testuj(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine(t3.WystapienieBledu);
            Console.ReadKey();
        }
    }
}
