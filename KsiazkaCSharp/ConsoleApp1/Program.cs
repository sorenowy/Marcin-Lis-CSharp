using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Liczba
    {
        private int liczba;
        public Liczba(int liczba)
        {
            this.liczba = liczba;
        }
        // Przeciazaony konstruktor bezarugmentowy
        public Liczba()
        {
            this.liczba = -1;
        }
        public void WyswietlLiczbe()
        {
            Console.WriteLine("Liczba wynosi: {0}",liczba);
        }
    }
    class Pole
    {
        private double liczba;
        private char znak;
        public Pole(double liczba)
        {
            this.liczba = liczba;
        }
        public Pole(char znak)
        {
            this.znak = znak;
        }
        public Pole(double liczba,char znak):this(liczba)
        {
            this.znak = znak;
        }
        public Pole(char znak, double liczba):this(znak)
        {
            this.liczba = liczba;
        }
        public void WyswietlWynik()
        {
            Console.WriteLine("Znak:{0}, Liczba:{1}", znak, liczba);
        }
    }
    class Prostokat
    {
        private int lewyX;
        private int lewyY;
        private int prawyX = 0;
        private int prawyY = 0;
        private int wysokosc;
        private int szerokosc;
        public Prostokat(int lewyX, int lewyY, int wysokosc, int szerokosc)
        {
            this.lewyX = lewyX;
            this.lewyY = lewyY;
            this.wysokosc = wysokosc;
            this.szerokosc = szerokosc;
        }
        public void Prezentuj()
        {
            Console.WriteLine($"Stworzony Prostokat posiada :\nlewy górny róg o współrzędnych : {lewyX},{lewyY}. Oraz prawy dolny róg o współrzędnych: {prawyX},{prawyY}," +
                $"\nposiada także {wysokosc} cm wysokosci oraz {szerokosc} cm szerokości.");
        }
    }
    public class Kwadrat
    {
        private int lewyX;
        private int lewyY;
        private int prawyX;
        private int prawyY;
        private int srodekX;
        private int srodekY;
        private double dlugosc;
        private double pole;

        public Kwadrat(int lewyX,int lewyY, int prawyX, int prawyY)
        {
            this.lewyX = lewyX;
            this.lewyY = lewyY;
            this.prawyX = prawyX;
            this.prawyY = prawyY;
        }
        public Kwadrat(int lewyX, int lewyY, double dlugosc)
        {
            this.lewyX = lewyX;
            this.lewyY = lewyY;
            this.dlugosc = dlugosc;
        }
        public Kwadrat(int srodekX, double dlugosc, int srodekY)
        {
            this.srodekX = srodekX;
            this.srodekY = srodekY;
            this.dlugosc = dlugosc;
        }
        public Kwadrat(double pole, int srodekX,int srodekY)
        {
            this.pole = pole;
            this.srodekX = srodekX;
            this.srodekY = srodekY;
        }
        public void Wyswietl()
        {
            Console.WriteLine($"Kwadrat zawiera następujące parametry:" +
                $"\nLewy górny róg o parametrach:{lewyX},{lewyY} oraz prawy dolny róg:{prawyX},{prawyY}" +
                $"\nSrodek kwadratu o parametrach:{srodekX},{srodekY}, oraz dlugosci boków {dlugosc} cm" +
                $"\nPole kwadratu wynosi:{pole}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* // ZADANIE 16.1-2
            Liczba liczba1 = new Liczba(5);
            liczba1.WyswietlLiczbe();
            Console.WriteLine();
            Liczba liczba2 = new Liczba();
            liczba2.WyswietlLiczbe();
            Console.ReadKey(); */
            /* // Zadanie 16.3-4
            Pole p1 = new Pole('a');
            Pole p2 = new Pole(11.22);

            Pole p3 = new Pole(33.44,'b');
            Pole p4 = new Pole('c',55.66);

            p1.WyswietlWynik();
            p2.WyswietlWynik();
            p3.WyswietlWynik();
            p4.WyswietlWynik();
            Console.ReadKey(); */
            /*
            //ZADANIE 16.5
            Prostokat p1 = new Prostokat(3, 4, 11, 14);
            p1.Prezentuj();
            Console.ReadKey(); */
            /*
            // ZADANIE 16.6-7
            Kwadrat k1, k2, k3, k4;
            k1 = new Kwadrat(4, 2, 7, 5);
            k2 = new Kwadrat(5, 5, 22.1);
            k3 = new Kwadrat(6, 21.4, 2);
            k4 = new Kwadrat(44.12, 6, 2);

            k1.Wyswietl();
            k2.Wyswietl();
            k3.Wyswietl();
            k4.Wyswietl();
            Console.ReadKey(); */
        }
    }
}
