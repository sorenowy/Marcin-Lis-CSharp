using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Zewnetrzna().g(); // Zadanie 33.1
            new Niezalezna().Metoda(); // Zadanie 33.2
            //Outside out2 = new Outside();
            //out2.getInside().g();
            Outside.Inside ins = new Outside.Inside();
            ins.g();    // Zadanie 33.3 -> Z racji ze jest klasa publiczna wewnetrzna, odwolujemy sie do typu
                        //dostepnego - tworzymy zmienna w klasie inside, i wywolujemy ich konstruktor, przez co moge wywolac metode g().
            Zew out1 = new Zew();
            out1.Wyswietl();
            Zew.Wew w1 = new Zew.Wew(out1);
            w1.Ustaw(55);
            out1.Wyswietl();
            Console.ReadKey();
        }
    }
}
