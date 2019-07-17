using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Zewnetrzna
    {
         private class Wewnetrzna
        {
            private int liczba = 100;
            public void Wyswietl()
            {
                Console.WriteLine("Klasa zawiera wartosc {0}", liczba);
            }
        }
        public void g()
        {
            Wewnetrzna wew = new Wewnetrzna();
            wew.Wyswietl();
        }
        
    }
    class Niezalezna
    {
        public void Metoda()
        {
            Zewnetrzna chleb = new Zewnetrzna();
            chleb.g();
        }
    }
}
