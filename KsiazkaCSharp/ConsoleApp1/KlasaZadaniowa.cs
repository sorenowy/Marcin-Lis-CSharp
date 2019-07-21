using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void DelegacjaZadania(KlasaZadaniowa obj);
    class KlasaZadaniowa
    {
        public string napis;
        public event DelegacjaZadania OnCalkowita;
        public event DelegacjaZadania OnRzeczywista;
        public void MetodaZadania(string napis)
        {
            this.napis = napis;
            try
            {
                Convert.ToDouble(napis);
                OnRzeczywista(this);
                if (double.Parse(this.napis) % 1 == 0)
                {
                    OnCalkowita(this);
                }
                else
                {
                    Console.WriteLine("Nie można rzutować do liczby całkowitej ");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Nie wpisałeś liczby!");
            }


        }
    }
}
