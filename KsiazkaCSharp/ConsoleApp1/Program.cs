using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public class MojObiekt : Object
    {
        public override string ToString()
        {
            return "Kurwa mac pierdole Ciebie" + base.ToString(); // Zwraca tekst wypisany przez przeciazenie metody + dopisuje komunikat bazowy :))
        }
    }
    class Glowna
    {
        public string x;
    }
    class Pochodna : Glowna
    {
        public string y;
    }
    public class Punkt // Zadanie 28.3
    {
        private int x;
        private int y;
        public Punkt(int wspX,int wspY)
        {
            this.x = wspX;
            this.y = wspY;
        }
        public override string ToString() // Przesłonienie metody ToString :)) // dziedziczy z Object ;)
        {
            return $"współrzędna x={x}, współrzędna y={y}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
             // Zadanie 28.1
            Pochodna p1 = new Pochodna();
            p1.x = "kurwa";
            p1.y = "mac";
            Console.WriteLine("x={0},y={1}", p1.x, p1.y);
            Glowna gl = (Glowna) p1;
            Console.WriteLine("x={0}", gl.x);
            Pochodna pl = (Pochodna)gl;
            Console.WriteLine("x={0},y={1}", pl.x, pl.y);
            Console.ReadKey();

            MojObiekt o1 = new MojObiekt(); // Zadanie 28.2
            Console.WriteLine(o1);

            Punkt punkt1 = new Punkt(5, 6); // Zadanie 28.3
            Console.WriteLine(punkt1);
            Console.ReadKey();
        }
    }
}
