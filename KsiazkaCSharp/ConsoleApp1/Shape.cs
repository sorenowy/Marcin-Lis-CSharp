using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Shape : Rysowanie
    {
        public string tekst;
        public Shape()
        {

        }
        public Shape(string tekstWpr)
        {
            this.tekst = tekstWpr;
        }
        public override void Draw()
        {
            Console.WriteLine("Jestem jakims ksztaltem " + tekst);
        }
    }
    class Circle : Shape, IDrawable
    {
        public override void Draw()
        {
            Console.WriteLine("Jestem Kołem! "+base.tekst);
        }
    }
    class Rectangle : Shape, IDrawable
    {
        public override void Draw()
        {
            Console.WriteLine("Jestem prostokatem!"+base.tekst);
        }
    }
    class Triangle : Shape, IDrawable
    {
        public override void Draw()
        {
            Console.WriteLine("Jestem trójkątem!"+base.tekst);
        }
    }
}
