using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangle
    {
        public void Diagonal()
        {
            Console.WriteLine("Diagonal Triangle");
        }
    }
    class Rectangle :Triangle
    {
        public new void Diagonal()
        {
            Console.WriteLine("Diagonal Rectangle");
        }
    }
    class Circle : Triangle
    {
        public new void Diagonal()
        {
            Console.WriteLine("Diagonal Circle:");
        }
    }
}
