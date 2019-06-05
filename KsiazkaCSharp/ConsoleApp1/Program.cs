using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /* // DO ZAPAMIETANIA JAK BUDOWAC KLASY Z WYKORZYSTANIEM OBIEKTU JAKO ARGUMENTU !!!
    public class Punkt
    {
        public int x;
        public int y;

        int PobierzX()
        {
            return x;
        }
        int PobierzY()
        {
            return y;
        }
        public void UstawX(int wspX)
        {
            x = wspX;
        }
        public void UstawY(int wspY)
        {
            y = wspY;
        }
        public void UstawXY(Punkt punkt)
        {
            x = punkt.x;
            y = punkt.y;
        }
        public Punkt PobierzXY()
        {
            Punkt punkt = new Punkt();
            punkt.x = x;
            punkt.y = y;
            return punkt;
        }
        public void WyswietlWspolrzedne()
        {
            Console.WriteLine("wspolrzedna x :" + x);
            Console.WriteLine("Wspolrzedna y :" + y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt();
            Punkt p2;
            p1.UstawX(100);
            p1.UstawY(200);

            Console.WriteLine("Pierwszy punkt ma wspolrzedne:");
            p1.WyswietlWspolrzedne();
            Console.WriteLine();

            p2 = p1.PobierzXY();

            Console.WriteLine("drugi puinkt ma wspolrzedne:");
            p2.WyswietlWspolrzedne();
            Console.WriteLine();

            Punkt p3 = new Punkt();
            p3.UstawXY(p2);
            Console.WriteLine("Trzeci punkt ma wspolrzedne:");
            p3.WyswietlWspolrzedne();
            Console.WriteLine();

            Punkt p4 = p3.PobierzXY();
            p4.WyswietlWspolrzedne();
            Console.ReadKey(); */

        /*
    public class Punkt      //Przeciążanie metody :)
    {
        public int x;
        public int y;

        public void UstawXY(int wspX, int wspY)
        {
            x = wspX;
            y = wspY;
        }
        public void UstawXY(Punkt punkt)
        {
            x = punkt.x;
            y = punkt.y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt();
            Punkt p2 = new Punkt();
            p1.UstawXY(100, 100);
            p2.UstawXY(200, 200);

            Console.WriteLine("Wartosc dla pierwszego punktu wynosi:");
            Console.WriteLine("X=" + p1.x);
            Console.WriteLine("y=" + p1.y);

            p1.UstawXY(p2);

            Console.WriteLine("po drugim ustawieniu wartosci");
            Console.WriteLine("x=" + p1.x);
            Console.WriteLine("y=" + p1.y);
            Console.ReadKey(); */

    public class Punkt
    {
        public int x;
        public int y;

        public int PobierzX()
        {
            return x;
        }
        public int PobierzY()
        {
            return y;
        }
        public void UstawX(int wspX)
        {
            x = wspX;
        }
        public void UstawY(int wspY)
        {
            y = wspY;
        }
        public int UstawX(Punkt punkt)
        {
            x = punkt.x;
            return x ;
        }
        public int UstawY(Punkt punkt)
        {
            y = punkt.y;
            return y;
        }
        public void UstawXY(int wspX,int wspY)
        {
            x = wspX;
            y = wspY;
        }
        public void UstawXY(Punkt punkt)
        {
            x=punkt.x;
            y=punkt.y;
        }
        public void Wyswietl()
        {
            Console.WriteLine("Wspolrzedna x=" + x);
            Console.WriteLine("wspolrzedna y=" + y); // ZADANIE 15.1/2/3
        }
    }
    public class Dzialania
    {
        public int licznik; // ZADANIE 15.5 i 15.6
        public int wynik;

        public int Dodaj(int x,int y)
        {
            wynik = x;
            x += y;
            licznik = x;
            return licznik;
        }
        public int Odejmij(int x,int y)
        {
            wynik = x;
            x -= y;
            licznik = x;
            return licznik;
        }
        public void PrezentujWynik()
        {
            Console.WriteLine("Wynik działania algebraicznego to :{0} z kolei zadeklarowana wartość to {1}",licznik,wynik); // ZADANIE 15.4
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt();
            p1.UstawX(100);
            p1.UstawY(100);
            Punkt p2 = new Punkt();
            p2.UstawX(200);
            p2.UstawY(400);
            Punkt p3 = new Punkt();
            p3.UstawY(p2);
            p3.UstawX(p1);
            p1.Wyswietl();
            Console.WriteLine();
            p2.Wyswietl();
            Console.WriteLine();
            p3.Wyswietl();
            Punkt p4 = new Punkt();
            p4.UstawXY(p3);
            Console.WriteLine();
            p4.Wyswietl();
            Console.ReadKey();
            Console.Clear();
            Dzialania d1 = new Dzialania();
            d1.Dodaj(5, 6);
            d1.PrezentujWynik();
            Console.WriteLine();
            d1.Odejmij(6, 5);
            d1.PrezentujWynik();
            Console.ReadKey();

        }
        
    }
}

