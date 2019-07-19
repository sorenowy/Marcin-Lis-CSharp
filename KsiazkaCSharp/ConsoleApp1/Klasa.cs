using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Klasa<T>
    {
        private T[] tab;
        public Klasa(int index)
        {
            tab = new T[index]; 
        }
        public void setItem(int index, T value)
        {
            tab[index] = value;
        }
        public T getItem(int index)
        {
            return tab[index];
        }
        public int Length
        {
            get
            {
                return tab.Length;
            }
        }
    }
}
