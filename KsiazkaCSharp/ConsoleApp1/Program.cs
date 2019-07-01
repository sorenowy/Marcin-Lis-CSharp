using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string plik; // Zadanie 27.1 i 27.3
            int ile;
            Console.WriteLine("Podaj nazwę scieżki docelowej dla pliku!");
            plik = Console.ReadLine();
            Console.WriteLine("jaki rozmiar tablicy chces zadeklarować ??");
            ile = int.Parse(Console.ReadLine());
            byte[] dane = new byte[ile];
            for (int i = 0; i < ile; i++)
            {
                if (i % 2 == 0)
                    dane[i] = 127;
                else
                    dane[i] = 255;
            }
            FileStream fs;
            try
            {  
                fs = new FileStream(plik, FileMode.Create);  
            }
            catch (Exception)
            {
                Console.WriteLine("Otwarcie pliku {0} nie powiodło się.", plik);
                return;
            }

            try
            {
                fs.Write(dane, 0, ile);
            }
            catch (Exception)
            {
                Console.WriteLine("Zapis nie został dokonany!");
            }
            fs.Close();
            Console.WriteLine("Zapis został dokonany!:)");

            FileStream fo;
            try
            {
                fo = new FileStream(plik, FileMode.Open);
            }
            catch (Exception)
            {
                Console.WriteLine("Otwarcie pliku {0} nie powiodło się!", plik);
                return;
            }
            try
            {
                fo.Read(dane, 0, ile);
                fo.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Odczyt nie został dokonany!");
            }
            Console.WriteLine("Z pliku {0} odczytano nastepujace dane !",plik);
            for (int j = 0; j < ile; j++)
            {
                Console.Write($"[{j}] = {dane[j]}  ");
                if (j %50 == 0)
                {
                    Console.WriteLine("\n");
                }
            }
            Console.ReadKey();
        }
    }
}
