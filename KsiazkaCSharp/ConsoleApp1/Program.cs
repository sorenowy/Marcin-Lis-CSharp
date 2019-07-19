using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TablicaInt
    {
        private int[] tab;
        public TablicaInt(int size)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException("rozmiar tablicy < 0");
            }
            tab = new int[size];
        }
        public int Get(int index)
        {
            if (index >= tab.Length || index < 0)
            {
                throw new IndexOutOfRangeException("Index = " + index);
            }
            else
            {
                return tab[index];
            }
        }
        public void Set(int index, int value)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Index = " + index);
            }
            if (index >= tab.Length)
            {
                Resize(index + 1);
            }
            tab[index] = value;
        }
        protected void Resize(int size)
        {
            int[] newTab = new int[size];
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
    class Program
    {
        static void Main(string[] args)
        {
            TablicaInt tablica = new TablicaInt(1);
            tablica.Set(100, 5);
            for (int i = 1; i < tablica.Length; i++)
            {
                Console.WriteLine($"Tablica {i} zawiera {tablica.Get(i)}");
            }
            Tablica rectangles = new Tablica(3);
            rectangles.Set(0, new Triangle());
            rectangles.Set(1, new Triangle());
            rectangles.Set(2, new Rectangle());
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles is Tablica)
                {
                    Console.WriteLine("Jest to obiekt :D");
                }
                ((Triangle)rectangles.Get(i)).Diagonal();
            }
            Console.WriteLine();
            Klasa<Object> klasa = new Klasa<Object>(5);
            klasa.setItem(0, 3.14);
            klasa.setItem(1, "kurwa");
            klasa.setItem(2, 2323);
            for (int i = 0; i < klasa.Length; i++)
            {
                Console.WriteLine(klasa.getItem(i));
            }
            Console.ReadKey();
        }
    }
}
