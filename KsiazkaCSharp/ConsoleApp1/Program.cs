using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Punkt // Zadanie 19.1
    {
        public int x;
        public int y;

        public int Odleglosc(int wspX, int wspY)
        {
            int odleglosc = 0;
            x = wspX;
            y = wspY;
            odleglosc = x + y;
            return odleglosc;
        }
        public void PrezentujOdcinek()
        {
            Console.WriteLine("odcinek miedzy x a y wynosi:" + Odleglosc(x, y));
        }
    }
    class Punkt3D : Punkt // Zadanie 19.2
    {
        private int z;

        public new int Odleglosc(int wspZ)
        {
            z = wspZ;
            int odleglosc = x + y + z;
            return odleglosc;
        }
        public void PrezentujOdcinek()
        {
            Console.WriteLine("Odcinek miedzy x,y,z wynosi:" + Odleglosc(z));
        }
    }
    class Dodawanie // Zadanie 19.3
    {
        public static void Dodaj(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("Wynik dodawania wynosi:" + c);
        }
    }
    class Przechowalnia // Zadanie 19.4
    {
        static int b = 0;
        public static void Przechowaj(int a)
        {
            b += a;
            Console.WriteLine("Wartość przechowana wynosi: " + b);
        }
    }
    class Cosik // Zadanie 19.5
    {
        static string tekst;
        public static void Wyswietl(string wprT)
        {
            tekst += wprT;
            Console.WriteLine(tekst);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Punkt3D p1 = new Punkt3D();
            p1.Odleglosc(5);
            p1.Odleglosc(5, 4);
            p1.PrezentujOdcinek();
            Dodawanie.Dodaj(5, 4);
            Przechowalnia.Przechowaj(3);
            Przechowalnia.Przechowaj(5);
            Przechowalnia.Przechowaj(9);
            Cosik.Wyswietl("kurwa");
            Cosik.Wyswietl(" ja cie pierdole ostro w dupe");
            Console.ReadKey();
        }
    }
}
