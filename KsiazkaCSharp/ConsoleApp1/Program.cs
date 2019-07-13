using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IRysowanie
    {
        void Rysuj2D();
        void Rysuj3D();
    }
    class Figura : IRysowanie
    {
        public void Rysuj2D()
        {
            Console.WriteLine("Metoda Rysuj2D");
        }
        public void Rysuj3D()
        {
            Console.WriteLine("Metoda Rysuj3D");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figura n = new Figura();
            n.Rysuj2D();
            n.Rysuj3D();
            Console.ReadKey();
            Shape sh1 = new Shape("kurwa");
            Circle c1 = new Circle();
            sh1.Draw();
            c1.Draw();
            r1.Draw();
            t1.Draw();
            Console.ReadKey();
        }
    }
}
