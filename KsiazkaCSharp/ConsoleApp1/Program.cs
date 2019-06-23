using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public void Metoda(string tekst)
        {
            if (tekst.Contains("a") || tekst.Contains("b") || tekst.Contains("c") == true)
            {
                string tekst1;
                tekst1 = tekst.Replace('a', 'k');
                tekst1 += tekst.Replace('b', 'h');
                tekst1 += tekst.Replace('c', 'j');
                Console.WriteLine(tekst1);
            }
            else Console.WriteLine(tekst);
            /* tekst = tekst.Replace('b', 'j');
             tekst = tekst.Replace('c', 'i');
             Console.WriteLine(tekst); */
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kurw mac"); // Zadanie 24.1
            Console.Write("\u004B\u0055\u0052\u0057\u0041!"); // Zadanie 24.2
            Console.WriteLine();
            string str = "Przykładowy tekst"; // Zadanie 24.3
            for (int i = str.Length; i > 0; i--)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(str[i - 1]);
                }
                Console.WriteLine();
            }
            string tekst = "ABCDEFGHIJKLMNOPRSTUWXYZabcdefghijklmnoprstuwxyz"; // Zadanie 24.4 
            Console.WriteLine("Alfabet w systemie szesnastkowym:");
            for (int i = 0; i < tekst.Length; i++)
            {
                Console.Write("{0} = {1:X} |",tekst[i],Convert.ToInt32(tekst[i]));
                if (i %10==0)
                {
                    Console.WriteLine("\n");
                }
            }
            Program p1 = new Program();
            p1.Metoda("abc");
            Console.ReadKey();
        }
    }
}
