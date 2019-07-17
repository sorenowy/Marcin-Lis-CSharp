using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Zew
    {
        private int wartosc;
        public class Wew
        {
            private Zew parent;
            public Wew()
            {

            }
            public Wew(Zew obj)
            {
                parent = obj;
            }
            public void Ustaw(int val)
            {
                parent.wartosc = val;
            }

        }
        public void Wyswietl()
        {
            Console.WriteLine("Pole wartosc = {0}", wartosc);
        }
    }
}
