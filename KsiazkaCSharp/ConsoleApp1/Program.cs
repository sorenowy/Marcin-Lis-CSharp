using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Punkt
    {
        public int x;
        public int y;

        public Punkt()
        {
            x = 1;
            y = 1;
        }
        public Punkt(int wspX,int wspY)
        {
            x = wspX;
            y = wspY;
        }
        public Punkt(Punkt punkt)
        {
            x = punkt.x;
            y = punkt.y;
        }
        public int PobierzX()
        {
            return x;
        }
        public int PobierzY()
        {
            return y;
        }
        public void UstawX(int x) // Zadanie 17.1
        {
            this.x = x;
        }
        public void UstawY(int y) // Zadanie 17.1
        {
            this.y = y;
        }
        public void UstawXY(int x,int y) // Zadanie 17.1
        {
            this.x = x;
            this.y = y;
        }
        public void WyswietlWspolrzedne()
        {
            Console.WriteLine("wspolrzedne x =" + x);
            Console.WriteLine("wspolrzedne y =" + y);
        }

    }
    class Punkt3D : Punkt
    {
        public int z;

        public Punkt3D()
        {
            x = 1;
            y = 1;
            z = 1;
        }
        public Punkt3D(int wspX,int wspY,int wspZ)
        {
            x = wspX;
            y = wspY;
            z = wspZ;
        }
        /*public Punkt3D(Punkt3D punkt) // ZADANIE 17.3
        {
            x = punkt.x;
            y = punkt.y;
            z = punkt.z;
        } */
        public Punkt3D(Punkt3D punkt):base(punkt) // ZADANIE 17.5
        {
            z = punkt.z;
        }
        public int PobierzZ()
        {
            return z;
        }
        public void UstawZ(int z)
        {
            this.z = z;
        }
        public void UstawXYZ(int x,int y,int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public void UstawYZ(int y,int z) // ZADANIE 17.2
        {
            this.y = y;
            this.z = z;
        }
        public void UstawXZ(int x,int z) // ZADANIE 17.2
        {
            this.x = x;
            this.z = z;
        }
        public void PrezentujXYZ()
        {
            Console.WriteLine("wspolczynnik x=" + x);
            Console.WriteLine("wspolczynnik y=" + y);
            Console.WriteLine("wspolczynnik z=" + z);
        }
    }
    class KolorowyPunkt : Punkt // ZADANIE 17.5
    {
        public int kolor;

        public KolorowyPunkt():base()
        {
            kolor = 1;
        }
        public KolorowyPunkt(int wspX, int wspY, int wspK) : base(wspX, wspY)
        {
            kolor = wspK;
        }
        public KolorowyPunkt(KolorowyPunkt punkt) : base(punkt)
        {
            kolor = punkt.kolor;
        }
        public int PobierzKolor()
        {
            return kolor;
        }
        public void UstawKolor(int kolor)
        {
            this.kolor = kolor;
        }
        public void PrezentujKolor()
        {
            Console.WriteLine("Kolor składa się z wartości:\nx={0},y={1},kolor={2}", x, y, kolor);
        }
    }
    class Program : Punkt3D
    {
       /* public int p;
        public Program() : base()
        {
            p = 1;
        }
        public Program(int wspX,int wspY,int wspZ,int wspP) : base(wspX,wspY,wspZ)
        {
            p = wspP;
        }
        public Program(Program program) : base(program)
        {
            p = program.p;
        } 
        void PrezentujProgram()
        {
            Console.WriteLine("Program zawiera następujące wartości:");
            Console.WriteLine("X =" + x);
            Console.WriteLine("Y=" + y);
            Console.WriteLine("Z=" + z);
            Console.WriteLine("P=" + p);
        } */
        static void Main(string[] args)
        {
            /*
            Punkt p1 = new Punkt();
            p1.UstawX(5);
            p1.UstawY(9);
            p1.WyswietlWspolrzedne();
            p1.UstawXY(66, 11);
            p1.WyswietlWspolrzedne();
            Console.ReadKey(); // ZADANIE 17.1
            Punkt3D z1 = new Punkt3D();
            z1.UstawXYZ(5, 4, 3);
            z1.PrezentujXYZ();
            Console.ReadKey();
            Console.Clear();
            Punkt3D z2 = new Punkt3D();
            z2.PrezentujXYZ();
            Console.Clear(); // Zadanie 17.2
            Program prog1 = new Program(); // ZADANIE 17.3
            Program prog2 = new Program(prog1);
            prog1.WyswietlWspolrzedne();
            Console.ReadKey();
            prog2.WyswietlWspolrzedne();
            Console.ReadKey(); */
            Punkt p1 = new Punkt(11, 22); // ZADANIE 17.5
            KolorowyPunkt k1 = new KolorowyPunkt();
            k1.PrezentujKolor();
            Console.ReadKey();
            KolorowyPunkt k2 = new KolorowyPunkt(p1.x,p1.y, 22);
            k2.PrezentujKolor();
            Console.ReadKey();
            KolorowyPunkt k3 = new KolorowyPunkt(k2);
            k3.PrezentujKolor();
            Console.ReadKey();
            Console.Clear();

            Punkt z2 = new Punkt(33, 22); // ZADANIE 17.6
            Punkt3D p3d = new Punkt3D(33, 22, 11);
            Punkt3D p2 = new Punkt3D();
            p2.PrezentujXYZ();
            Console.ReadKey();

        }
    }
}
