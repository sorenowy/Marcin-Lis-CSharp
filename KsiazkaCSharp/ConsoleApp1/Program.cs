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
        private double x;
        private double y;

        public int PobierzR()
        {
            double r = (x * x + y + y);
            return (int) r;
        }
        public void UstawR(int wspX)
        {
            x = wspX;
            y= 
        }
        public int PobierzSinusalfa()
        {
            double sinusalfa = y / r
        }
        public void UstawSinusalfa(int wspY)
        {
            y = wspY;
            x=
        }
        public void PrezentujKlase()
        {
            Console.WriteLine("Punkt okreslony w działach kartezjańskich wynosi:");

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
