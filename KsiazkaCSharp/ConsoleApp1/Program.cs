using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Punktos
    {
        private int _x;
        private int _y;

        public int x { get; set; } // ZADANIE 20.6 - dodanie akcesorow getset;
       /* { // ZADANIE 20.5
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        } */
        public int y { get; set; }
       /* { // ZADANIE 20.5
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        } */
        public Punktos(int wspX, int wspY) // Zadanie 20.5 . Struktura musi pobierac wszystkie wartosci w przypadku konstruktora. Tutaj private inty przyjmuja wartosc argumentow az pozniej przekazuja je do wartosic public;
            // W przypadku automatycznych akcesorow get;set, musze zadeklarowac zmiane wartosci public z private, bo te akcesory nie maja definicji wartosci przyjetej
        {
            _x = wspX;
            _y = wspY;
            y = _y;
            x = _x;
        }
        public void Prezentuj()
        {
            Console.WriteLine("Punkt x wynosi {0} a punkt y {1}", x, y);
        }
    }

    class WartoscCalkowita // Zadanie 20.4
    {
        private int _wcalk;
        public int wcalk
        {
            get // getter w tym przypadku pobiera wartosc private inta i ustawia wartosc private inta wedlug wzoru;
            {
                return _wcalk = 2 * (_wcalk - 1) - 2;
            }
            set // setter pobiera wartosc deklarowana przy inicjalizacji obiektu;
            {
                _wcalk = value;
            }
        }
    }
    class Wartosc // ZADANIE 20.3
    {
        private int _liczba;
        public int liczba
        {
            get // pobiera wartosc ustalona dla _liczbe - czyli w przypadku w1.liczba =6/2=3 \\\ To w1.liczba zwroci i ustawi nam (3+3)*2=12 podwojona zadeklarowana wartosc :)
            {
                return (_liczba + _liczba)*2;
            }
            set // setter ustawia nam wartosc naszej liczby publicznej (jezeli w1.liczba ma wart. 6 = to ustawia _liczbe  = 6/2 = 3)
            {
                _liczba = value /2;
            }
        }
    }
    class Punkt // ZADANIE 20.1
    {
        private int x;
        public int _x
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        private int y;
        public int _y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public void Prezentuj()
        {
            Console.WriteLine("Punkt X = " + x);
            Console.WriteLine("punkt y = " + y);
        }
        /*public Punkt(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public void UstawXY(int x,int y)
        {
            x = this.x;
            y = this.y;
        }
        public void Prezentuj()
        {
            Console.WriteLine("Punkt X = "+x);
            Console.WriteLine("punkt y = " + y);
        } */
    }
    class Punkt3D : Punkt
    {
        private int z;
        public int _z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        public new void Prezentuj()
        {
            base.Prezentuj();
            Console.WriteLine("Punkt Z = " + z);
        }
        /*public Punkt3D(int x,int y, int z) : base(x,y)
        {
            this.z = z;
        }
        public void UstawZ(int z)
        {
            this.z = z;
        }
        public new void Prezentuj() 
        {
            base.Prezentuj();
            Console.WriteLine("Punkt z = " + z);
        } */

    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Punkt p1 = new Punkt(2, 4);
            Punkt3D p2 = new Punkt3D(3,4, 5);
            p1.Prezentuj();
            Console.WriteLine("-------------");
            p2.Prezentuj();
            Console.ReadKey();*/
            Punkt p1 = new Punkt();
            p1._x = 22;
            p1._y = 33;
            Punkt3D p2 = new Punkt3D();
            p2._x = p1._x;
            p2._y = p1._y;
            p2._z = 22;
            Console.WriteLine(p1._x);
            Console.WriteLine(p1._y);
            Console.WriteLine("--@#_@#_#@_#@_#_@#--");
            p2.Prezentuj();
            Console.ReadKey();
            Wartosc w1 = new Wartosc();
            w1.liczba = 22;
            Console.WriteLine(w1.liczba);
            Console.Clear();
            WartoscCalkowita wc1 = new WartoscCalkowita();
            wc1.wcalk = 15;
            Console.WriteLine("Wartość całkowita wynosi" + wc1.wcalk);
            Console.ReadKey();
            Console.Clear();
            Punktos pu1 = new Punktos();
            pu1.Prezentuj();
            pu1 = new Punktos(3, 5);
            pu1.Prezentuj();
            pu1.x = 5;
            pu1.y = 7;
            pu1.Prezentuj();
            Punktos pu2 = new Punktos();
            pu2.x = 1;
            pu2.y = 5;
            pu2.Prezentuj();
            Console.ReadKey();
            Console.Clear();
            pu2 = new Punktos(4, 5);
            pu2.Prezentuj();
            Console.ReadKey();
        }
    }
}
