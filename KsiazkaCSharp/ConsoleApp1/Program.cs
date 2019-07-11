using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Glowna // Zadanie 29.2
    {
        public override string ToString()
        {
            return "Jestem obiektem klasy " +this.GetType();
        }
    }
    class Pochodna : Glowna
    {
        public override string ToString()
        {
            return base.ToString();
        }
    }

    class Punkt // Zadanie 29.1
    {
        public int x;
        public int y;
    }
    class Punkt3D : Punkt
    {
        public int z;
    }
    class Program
    {
        public static void DrawShape(Rysuj shape) // Zadanie 29.3 i 4
        {
            shape.Draw();
        }
        static void Main(string[] args)
        {
            /*try
            {
                Punkt punkt = new Punkt();
                Punkt3D punkt3d = (Punkt3D)punkt;
                punkt3d.z = 10;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } */
            Glowna glowna = new Glowna();
            Console.WriteLine(glowna);
            Pochodna pochodna = new Pochodna();
            Console.WriteLine(pochodna);
            Console.ReadKey();
            Triangle triangle = new Triangle();
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();
            Shape ksztalt = new Shape();
            Rysuj cos = new Rysuj();
            Console.WriteLine();

            DrawShape(circle);
            DrawShape(rectangle);
            DrawShape(triangle);
            DrawShape(ksztalt);
            DrawShape(cos);
            Console.ReadKey();
        }
    }
}
