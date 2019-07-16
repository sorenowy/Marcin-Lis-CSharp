using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IKolejnyPierwszyInterfejs
    {
        void f();
        void f(int argument);
    }
    interface IKolejnyDrugiInterfejs
    {
        void f();
        void f(double argument);
    }
    class KolejnaKlasa : IKolejnyDrugiInterfejs, IKolejnyPierwszyInterfejs
    {
        public void f()
        {
            Console.WriteLine("Metoda F");
        }
        public void f(int argument)
        {
            Console.WriteLine("Metoda zawiera " + argument);
        }
        public void f(double argument)
        {
            Console.WriteLine("Metoda zawiera " + (int)(argument));
        }
    }
}
