using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IInterfejs
    {
        int x { get; set; }
        double y { get; set; }
    }
    interface IPunkt3D : IInterfejs
    {
        int z { get; set; }
    }
    class Klasa : IInterfejs
    {
        private int intx;
        private double doubley;
        public int x
        {
            get
            {
                return intx;
            }
            set
            {
                intx = value;
            }
        }
        public double y
        {
            get
            {
                return doubley;
            }
            set
            {
                doubley = value;
            }
        }
    }
    class Punkt3D : Klasa, IPunkt3D
    {
        private int punktZ;
        public int z
        {
            get
            {
                return punktZ;
            }
            set
            {
                punktZ = value;
            }
        }
    }
}
