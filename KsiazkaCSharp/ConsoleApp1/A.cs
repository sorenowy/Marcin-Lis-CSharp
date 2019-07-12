using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class A
    {
        public int dzielnik;
        public A(int dzielnik)
        {
            //Console.WriteLine("Konstruktor klasy A");
            this.dzielnik = dzielnik;
            f();
        }
        public virtual void f()
        {
            Console.WriteLine("Klasa A , metoda f()");
        }
    }
    class B : A
    {
        public B(int dzielnik) : base(dzielnik)
        {
            //Console.WriteLine("konstruktor klasy b");
        }
        public override void f()
        {
            try
            {
                double wynik = 1 / dzielnik;
                Console.WriteLine("Dzielenie calkowite 100 / {0} daje wynik {1}", dzielnik, wynik);
            }
            catch (DivideByZeroException blad)
            {
                Console.WriteLine(blad.Message);
            }
        }
    }
}
