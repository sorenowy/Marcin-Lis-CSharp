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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("argumenty wywolania");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            Console.ReadKey();
        }
        
    }
}

