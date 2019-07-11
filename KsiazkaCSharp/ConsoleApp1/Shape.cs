using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Shape : Rysuj
    {
        public override void Draw()
        {
            Console.WriteLine("Jestem jakimś tam kształtem!");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Jestem prostokątem!");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Jestem kołem!");
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Jestem trójkątem!");
        }
    }
}
