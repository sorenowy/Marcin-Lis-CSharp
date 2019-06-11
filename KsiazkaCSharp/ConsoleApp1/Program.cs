using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Punkt
    {
        /*private int x;
        private int y;

        public int PobierzX()
        {
            return x;
        }
        public int PobierzY()
        {
            return y;
        }
        public void UstawX(int wspX)
        {
            x = wspX;
        }
        public void UstawY(int wspY)
        {
            y = wspY;
        } */
        private double sinusalfa;
        private double r;

        public int PobierzX()
        {
            double x = r * Math.Sqrt(1-sinusalfa * sinusalfa);
            return (int) x;
        }
        public int PobierzY()
        {
            double y = r * sinusalfa;
            return (int) y;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            /*Punkt punkt1 = new Punkt();
            punkt1.UstawX(100);
            punkt1.UstawY(200);
            Console.WriteLine(punkt1.PobierzX());
            Console.WriteLine(punkt1.PobierzY());
            Console.ReadKey();
            Console.Clear();*/

        }
    }
}
