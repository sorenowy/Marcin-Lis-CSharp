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
            int[][] tab= new int[4][];
            tab[0] = new int[4];
            tab[1] = new int[2];
            tab[2] = new int[1];
            tab[3] = new int[3];
            int licznik = 10;
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    tab[i][j] = licznik--;
                }
            }
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write("tab[{0}]= ", i);
                for (int j = 0; j < tab[i].Length; j++)
                {
                    Console.Write("{0},",tab[i][j]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey(); */ // ZADANIE 13.1

            /*
            int[][] tablica = new int[4][];
            tablica[0] = new int[4];
            tablica[1] = new int[3];
            tablica[2] = new int[2];
            tablica[3] = new int[1];

            int licznik = 1;
            int i = 0;
            int j = 0;


            while (i < tablica.Length)
            {
                Console.Write("Tablica=[{0}] = ", i);
                while (j < tablica[i].Length)
                {
                    tablica[i][j] = licznik++;
                    Console.Write("{0},", tablica[i][j]);
                    j++;
                }
                i++;
                j = 0;
                Console.WriteLine("");
            }
            Console.ReadKey(); */ // ZADANIE 13.2

            /*
            int[][] tablica = new int[4][];
            tablica[0] = new int[1];
            tablica[1] = new int[2];
            tablica[2] = new int[3];
            tablica[3] = new int[4];

            int licznik = 10;
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    tablica[i][j] = licznik--;
                }
            }
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write("tablica = [{0}]", i);
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    Console.Write(" {0}, ", tablica[i][j]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey(); */ // ZADANIE 13.3
            /*
            bool[,] tablica= new bool[5, 8];
            int prawda = 1;
            int falsz = 0;
            for(int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            tablica[i, j] = true;
                        }
                    }
                    else
                        tablica[i, j] = false;
                }
            }
            for(int i = 0; i < tablica.GetLength(0); i++)
            {
               for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    if (tablica[i, j] == true)
                    {
                        Console.WriteLine("Tablica [{0},{1}] wynosi {2}", i, j, prawda);
                    }
                    else
                    Console.WriteLine("Tablica [{0},{1}] wynosi {2}", i, j, falsz);
                }
                Console.WriteLine();
            }
            Console.ReadKey(); */
            // Zadanie 13.4

            /*
            int wysokosc, szerokosc, dlugosc;
            Console.WriteLine("Podaj dlugosc prostopadloscianu");
            dlugosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj szerokosc prostopadloscianu");
            szerokosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wysokosc prostopadloscianu");
            wysokosc = int.Parse(Console.ReadLine());
            int[,,] prostopadloscian = new int[dlugosc, szerokosc, wysokosc];
            for(int i = 0; i < prostopadloscian.GetLength(0); i++)
            {
                for (int j = 0; j < prostopadloscian.GetLength(1); j++)
                {
                    for (int k = 0; k < prostopadloscian.GetLength(2); k++)
                    {
                        Console.WriteLine("podaj wartość dla {0},{1},{2} komórki prostopadloscianu", i + 1, j + 1, k + 1);
                        prostopadloscian[i,j,k] = int.Parse(Console.ReadLine());
                    }
                }
            }
            for (int i = 0; i < prostopadloscian.GetLength(0); i++)
            {
                for (int j = 0; j < prostopadloscian.GetLength(1); j++)
                {
                    for (int k = 0; k < prostopadloscian.GetLength(2); k++)
                    {
                        Console.WriteLine("Prostopadloscian {0},{1},{2} zawiera następujące wartości {3}", i, j, k, prostopadloscian[i, j, k]);
                    }
                }
            }
            Console.ReadKey(); */ // Zadanie 16.5

            /*
            Console.WriteLine("podaj wartosc dlugosci tablicy:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int[,] tablica = new int[a,b];
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                int d = (i + 1) + (i - 1);
                int x = Convert.ToInt32(tablica.GetLength(1)); // Pobiera dlugosc wierszy (b)
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    if (d < 0)
                    {
                        tablica[i, j] = 0;
                    }
                    else
                    tablica[i, j] = d--;                    // Dekrementacja , po wyjsciu z petli przyjmuje wartosc {b}
                    
                }
            }
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                Console.Write("Tablica {0} wynosi:",i);
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    Console.Write("{0}, ", tablica[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();  // Zadanie 16.6 niekompletne */
            Console.WriteLine("podaj wartość dlugosci tablicy");
            int a = int.Parse(Console.ReadLine());
            int licznik = 0;
            int[][]tablica = new int[a][];
            for (int i = 0; i < tablica.Length; i++)
            {
                if (i == 0)
                {
                    licznik = 0;
                }
                else if (i == 1)
                {
                    licznik = 1;
                }
                else if (i > 1)
                {
                    licznik = (i - 1) + (i - 2);
                }
                else
                    licznik = i;
                tablica[i] = new int[licznik];
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    
                    tablica[i][j] = licznik--;
                }
            }
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write("Tablica {0} wynosi:", i);
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    Console.Write("{0}, ", tablica[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey(); // ZADANIE 16.6
        }
    }
}
