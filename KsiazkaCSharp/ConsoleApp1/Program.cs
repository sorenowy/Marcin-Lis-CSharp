using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GeneralException : Exception // Zadanie 23.4
    {
        public GeneralException(String msg) : base(msg)
        {

        }
    }
    class NegativeValueException : Exception // Zadanie 23.3
    {
        public void Test()
        {
            throw new NegativeValueException();
        }
    }
    class Program : NegativeValueException // ZADANIE 23.3
    {
        private int a;
        private int b;
        public void WyjatekGlowny(String msg)
        {
            throw new GeneralException(msg);
        }
        private int Odejmij(int wspA,int wspB)
        {
            a = wspA;
            b = wspB;
            return wspA -= wspB ;
        }
        public void f()
        {
            // throw new NullReferenceException(); ///Zadanie 23.1
            Console.WriteLine("Wynik odejmowania wynosi: {0}",Odejmij(a,b));
            base.Test();
        }
        static void Main(string[] args)
        {
            /* Program p1; /// ZADANIE 23.1
            try
            {
                p1 = null;
                p1.f();
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            } */
            /* int[] tablica = new int[10]; /// ZADANIE 23.2
            int liczba1 = 11,liczba2 = 0;
            try
            {
                try
                {
                    tablica[liczba1] = liczba2;
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Tutaj wyjatek zostal przechwycony pierwszy raz:");
                    throw e;
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("tutaj wyjatek zostal przechwycony drugi raz");
                Console.WriteLine(e.ToString());
            } */
            /*int a, b;
            Program p1 = new Program();
            Console.WriteLine("Podaj wartosc pierwszej liczby");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj wartosc drugiej liczby");
            b = int.Parse(Console.ReadLine());
            p1.Odejmij(a, b);*/
            Program p2 = new Program();
            
            try
            {
                //p1.f();
                p2.WyjatekGlowny("kurwa mac zjebalo sie !");
            }
           /* catch(NegativeValueException e)
            {
                Console.WriteLine(e.Message);
            } */
            catch(GeneralException f) // Zadanie 23.4
            {
                Console.WriteLine(f.Message);
            }
            Console.ReadKey();
        }
    }
}
