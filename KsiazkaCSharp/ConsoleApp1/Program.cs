using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] tablica = new int[10];
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("Wprowadz wartosci tablicy dla tablicy {0}", i + 1);
                tablica[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < tablica.Length; j++)
            {
                Console.Write(tablica[j]+" ");
            } */                                   // ZADANIE 12.1
            /*
            int[] tablica = new int[10];
            Console.WriteLine("Podaj wartosc dla tablicy którą chcesz zwielokrotnic");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i < tablica.Length; i++)
            {
                tablica[0] = x;
                tablica[i] = tablica[i-1] + x;   
            }
            foreach (int t in tablica)
            {
                Console.Write($"{t} ");
            }   */                                    // ZADANIE 12.2
            /*
            bool[] tablica = new bool[20];
            for (int i = 0; i < tablica.Length; i++)
            {
                if (i % 2 == 0)
                {
                    tablica[i] = true;
                    Console.WriteLine("Tablica nr {0} ={1}", i, tablica[i]);
                }
                if (i % 2 == 1)
                {
                    tablica[i] = false;
                    Console.WriteLine("Tablica nr {0} ={1}", i, tablica[i]);
                }
            } */    // ZADANIE 12.3
            /*
            int[] tablica = new int[100];
            for (int i = 0; i < tablica.Length; i++)
            {
                if (i % 10 == 0)
                {
                    tablica[i] = 0;
                    Console.WriteLine("Tablica {0} ma wartość : {1}", i, tablica[i]);
                }
                if (i % 10 == 1)
                {
                    tablica[i] = 1;
                    Console.WriteLine("Tablica {0} ma wartość : {1}", i, tablica[i]);
                }
                if (i % 10 == 2)
                {
                    tablica[i] = 2;
                    Console.WriteLine("Tablica {0} ma wartość : {1}", i, tablica[i]);
                }
                if (i % 10 == 3)
                {
                    tablica[i] = 3;
                    Console.WriteLine("Tablica {0} ma wartość : {1}", i, tablica[i]);
                }
                if (i % 10 == 4)
                {
                    tablica[i] = 4;
                    Console.WriteLine("Tablica {0} ma wartość : {1}", i, tablica[i]);
                }
                if (i % 10 == 5)
                {
                    tablica[i] = 5;
                    Console.WriteLine("Tablica {0} ma wartość : {1}", i, tablica[i]);
                }
                if (i % 10 == 6)
                {
                    tablica[i] = 6;
                    Console.WriteLine("Tablica {0} ma wartość : {1}", i, tablica[i]);
                }
                if (i % 10 == 7)
                {
                    tablica[i] = 7;
                    Console.WriteLine("Tablica {0} ma wartość : {1}", i, tablica[i]);
                }
                if (i % 10 == 8)
                {
                    tablica[i] = 8;
                    Console.WriteLine("Tablica {0} ma wartość : {1}", i, tablica[i]);
                }
                if (i % 10 == 9)
                {
                    tablica[i] = 9;
                    Console.WriteLine("Tablica {0} ma wartość : {1}", i, tablica[i]);
                }
            }
            Console.ReadKey(); */   // ZADANIE 12.4

            /*
            char[] tablica = new char[23]{ 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'w', 'y', 'z' };
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }
            Console.ReadKey(); */ //ZADANIE 12.5
        }
    }
}
