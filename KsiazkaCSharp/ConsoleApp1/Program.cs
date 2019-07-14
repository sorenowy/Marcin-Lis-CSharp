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
            Triangle t1 = new Triangle();
            Rectangle r1 = new Rectangle();
            sh1.Draw();
            c1.Draw();
            r1.Draw();
            t1.Draw();
            Console.ReadKey();
            Klasa k1 = new Klasa();
            k1.x = 6;
            k1.y = 7.5;
            Console.WriteLine(k1.y);
            Console.WriteLine(k1.x);
            Console.ReadKey();
            Console.Clear(); 
            // -------------------- ZADANIE 31.5 //
            Punkt3D punkt3d1 = new Punkt3D();
            punkt3d1.x = 10;
            punkt3d1.y = 20;
            punkt3d1.z = 30;
            Console.WriteLine("Punkt3D1");
            Console.WriteLine("x = " + punkt3d1.x);
            Console.WriteLine("y = " + punkt3d1.y);
            Console.WriteLine("z = " + punkt3d1.z);
            Klasa punkt1 = (Klasa)punkt3d1;
            Console.WriteLine("Punkt1");
            Console.WriteLine("x = " + punkt1.x);
            Console.WriteLine("y = " + punkt1.y);
            Punkt3D punkt3d2 = (Punkt3D)punkt1;
            Console.WriteLine("Punkt3D2");
            Console.WriteLine("x = " + punkt3d2.x);
            Console.WriteLine("y = " + punkt3d2.y);
            Console.WriteLine("z = " + punkt3d2.z);
            Console.ReadKey();
        }
    }
}
