using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tablica
    {
        private Object[] tab;
        public Tablica(int size)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException("Size<0");
            }
            else
            {
                tab = new Object[size];
            }
        }
        public Object Get(int index)
        {
            if (index >= tab.Length || index < 0)
            {
                throw new IndexOutOfRangeException("Index = "+index);
            }
            else
            {
                return tab[index];
            }
        }
        public void Set(int index,Object obj)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index = "+index);
            }
            else if (index >= tab.Length)
            {
                Resize(index + 1);
            }
            else
            {
                tab[index] = obj;
            }
        }
        protected void Resize(int size)
        {
            Object[] newTab = new Object[size];
            for (int i = 0; i < tab.Length; i++)
            {
                newTab[i] = tab[i];
            }
            tab = newTab;
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
