using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /*public abstract class Glowna // Zadanie 30.1
    {
        public abstract void Wyswietl();
    }
    class Potomna : Glowna
    {
        public override void Wyswietl()
        {
            Console.WriteLine("Jestem obiektem klasy Pochodna / {0}", this.GetType());
        }
    } */
    abstract class First
    {
        public abstract void f();
    }
    abstract class Second : First
    {
        public abstract void g();
    }
    class Third : Second
    {
        public override void f()
        {
            Console.WriteLine("Wywołanie metody f() z klasy Third.");
        }
        public override void g()
        {
            Console.WriteLine("Wywołanie metody g() z klasy Third.");
        }
        public void Wyswietl()
        {
            f();
            g();
        }
    }
    class Program : Potomna
    {
        Glowna glowna = new Glowna();
        Potomna obiekt = new Potomna(); 

        public Program()
        {
            Console.WriteLine("Konstruktor klasy program!");
        }
        static void Main(string[] args)
        {
            /*Potomna p = new Potomna();
            p.Wyswietl();
            Console.ReadKey();
            Console.Clear();
            Third t = new Third();
            t.Wyswietl(); */
            Program programP = new Program();
            Console.WriteLine();
            B b = new B(22);
            b.f();
            Console.ReadKey();

        }
    }
}
