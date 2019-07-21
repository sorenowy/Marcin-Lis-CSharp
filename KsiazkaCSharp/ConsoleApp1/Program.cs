using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void Delegacja();
    public delegate void DelegacjaNapis(string napis);
    class Program
    {
        delegate string DelegacjaOdejmij(double x, double y);
        public static void Metoda1()
        {
            Console.WriteLine("Metoda 1");
        }
        public static void Metoda2(string napis)
        {
            Console.WriteLine(napis);
        }
        static string Odejmij(double a, double b)
        {
            return $"Wynik to:{a -= b}";
        }
        static void WyswietlW1(Kontener obj)
        {
            Console.WriteLine("Wartość w1 = {0}", obj.w1);
        }
        static void WyswietlW2(Kontener obj)
        {
            Console.WriteLine("Wartosc w2 = {0}", obj.w2);
        }
        static void OnCalkowitaKomunikat(KlasaZadaniowa obj)
        {
            Console.WriteLine("Obiekt jest liczbą całkowitą "+obj.napis);
        }
        static void OnRzeczywistaKomunikat(KlasaZadaniowa obj)
        {
            Console.WriteLine("Obiekt jest liczba rzeczywistą " + obj.napis);
        }
        static void Main()
        {
            Delegacja del1 = Metoda1;
            DelegacjaNapis del2 = Metoda2;
            del1();
            del2("To druga metoda");
            DelegacjaOdejmij delo1 = Odejmij;
            Console.WriteLine(delo1(2.22, 3.42));
            Console.ReadKey();
            Console.WriteLine("--");
            Kontener k = new Kontener();
            WyswietlDelegacje wdel = WyswietlW1;
            wdel += WyswietlW2;
            k.CallBackWyswietl(wdel);
            Console.WriteLine("--");
            wdel -= WyswietlW1;
            k.CallBackWyswietl(wdel);
            Console.WriteLine("--");
            wdel += WyswietlW1;
            wdel -= WyswietlW2;
            k.CallBackWyswietl(wdel);
            Console.WriteLine("--");
            wdel += WyswietlW2;
            wdel += WyswietlW2;
            k.CallBackWyswietl(wdel);
            Console.ReadKey();
            Console.WriteLine("@@");
            KlasaZadaniowa kz = new KlasaZadaniowa();
            kz.OnCalkowita += OnCalkowitaKomunikat;
            kz.OnRzeczywista += OnRzeczywistaKomunikat;
            kz.MetodaZadania("3,5");
            kz.MetodaZadania("5");
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
