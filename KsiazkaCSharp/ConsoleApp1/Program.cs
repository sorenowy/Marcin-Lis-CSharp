using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IPierwszyInterfejs
    {
        void f();
        void g();
        void h(int argument);
    }
    public interface IDrugiInterfejs
    {
        void f();
        void g();
        void h(double argument);
    }
    class MojaKlasa : IPierwszyInterfejs, IDrugiInterfejs
    {
        public void f()
        {
            Console.WriteLine("METODA F!");
        }
        public void g()
        {
            Console.WriteLine("METODA G!");
        }
        public void h(int argument)
        {
            Console.WriteLine("Argument = " + argument);
        }
        public void h(double argument)
        {
            Console.WriteLine("ARGUMENT = " + argument);
        }
    }
    class Radio : IWydajeDzwiek
    {
        public void Graj()
        {
            Console.WriteLine("Wydaje dzwiek, lalalallala!");
        }
    }
    class Telewizor : IWyswietlajObrazIWydajeDzwiek
    {
        /* public void GrajIWyswietl() */
        //Console.WriteLine("POKAZUJE OBRAZ I DZWIEK!@@@@!");
        public void Graj()
        {
            Console.WriteLine("Gram dzwiek!");
        }
        public void Wyswietl()
        {
            Console.WriteLine("Pokazuje Obraz!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa klasa = new MojaKlasa();
            klasa.f();
            klasa.g(); // Zadanie 32.1
            MojaKlasa klasaARG = new MojaKlasa();
            klasaARG.h(22);
            klasaARG.h(2.6); // Zdanie 32.2

            Telewizor t1 = new Telewizor();
            //t1.GrajIWyswietl();*/ //Zadanie 32.3
            t1.Graj();
            t1.Wyswietl(); //Zadanie 32.4
            KolejnaKlasa k1 = new KolejnaKlasa();
            k1.f();
            k1.f(22);
            k1.f(21.1);
            Console.ReadKey();
        }
    }
}
