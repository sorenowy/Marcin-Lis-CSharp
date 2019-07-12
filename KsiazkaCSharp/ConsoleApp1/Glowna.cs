using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Glowna // Klasy stosowane w zadaniach 30.3-5
    {
        public Glowna()
        {
            Console.WriteLine("Konstruktor klasy Główna");
        }
    }
    class Potomna : Glowna
    {
        public Potomna()
        {
            Console.WriteLine("Konstruktor klasy potomna!");
        }
    }
}
