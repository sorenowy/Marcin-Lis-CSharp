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
            string katalog;
            string nazwa;
            Console.WriteLine("Podaj nazwę katalogu:");
            katalog = Console.ReadLine();
            
            Console.WriteLine("Ile podkatalogow chcesz utworzyc??");
            int liczba = int.Parse(Console.ReadLine());
            DirectoryInfo di = new DirectoryInfo(katalog);
            for (int i = 0; i < liczba; i++)
            {
                Console.WriteLine("Podaj nazwę subkatalogu dla {0} podkatalogu", i + 1);
                di.CreateSubdirectory(Console.ReadLine());
            }
            Console.WriteLine("Podaj nazwe w celu wyszukania, użyj * aby zawężyć pole wyszukiwania:");
            nazwa = Console.ReadLine();
            DirectoryInfo[] dire = di.GetDirectories(nazwa);
            foreach (DirectoryInfo dir in dire)
            {
                Console.WriteLine(dir.Name);
            }
            Console.WriteLine("Wyszukiwany jest katalog {0} oraz pliki o haśle {1}", katalog, nazwa);

            Console.ReadKey();
        }
    }
}
