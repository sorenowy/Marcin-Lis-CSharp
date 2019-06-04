using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    /*
    public class LiczbaCalkowita
    {
        int x;
        int pobierzliczbe()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        public void WyswietlLiczbe()
        {
            Console.WriteLine("Liczba pobrana wynosi " + pobierzliczbe());
        }
    } */ // ZADANIE 14.1
    /*
    public class Prostokat
    {
        public int a;
        public int a1;
        public int b;
        public int b1;
        public int c;
        public int c1;
        public int d;
        public int d1;

        int PunktA()
        {
            return a;
        }
        int PunktB()
        {
            return b;
        }
        int PunktC()
        {
            return c;
        }
        int PunktD()
        {
            return d;
        }
        public void WyswietlProstokat()
        {
            Console.WriteLine($"Prostokąt o nr zawiera: punkt A:{PunktA()} punkt B:{PunktB()} punktC:{PunktC()} punktD:{PunktD()}");
        }
    }
    */
    public class Prostokat
    {
        public int lewyX;
        public int lewyY;
        public int prawyX;
        public int prawyY;
       
        int PunktA()
        {
           return lewyX;
        }
        int PunktB()
        {
            return prawyX;
        }
        int PunktC()
        {
            return lewyY;
        }
        int PunktD()
        {
            return prawyY;
        }
        public void PrezentujProstokat()
        {
            Console.WriteLine("Prostokat zawiera punkty A:{0},{1} i B:{2},{3}", PunktA(),PunktB(),PunktC(),PunktD());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat p1 = new Prostokat();
            p1.lewyX = int.Parse(Console.ReadLine());
            p1.prawyX = int.Parse(Console.ReadLine());
            p1.lewyY = int.Parse(Console.ReadLine());
            p1.prawyY = int.Parse(Console.ReadLine());
            p1.PrezentujProstokat();
            Console.ReadKey(); // ZADANIE 14.2-3-4
        }
    }
}
