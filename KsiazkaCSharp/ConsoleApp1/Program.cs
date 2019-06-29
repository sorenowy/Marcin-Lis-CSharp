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
            /* Console.WriteLine("Zawartość katalogu bieżacego:"); // ZADANIE 26.1 (Program pobierajacy i ustawiajacy settery nt. katalogu, zrodla, czas utworzenia katalogu.//
                DirectoryInfo di = new DirectoryInfo(".");
                DirectoryInfo[] katalogi = di.GetDirectories();
                Console.WriteLine("Zródło katalogu: "+di.Attributes);
                Console.WriteLine("Nadrzędny katalog: " + di.Parent); // Master
                Console.WriteLine("Czas utworzenia katalogu: " + di.CreationTime); // Pobiera czas utworzenia
                di.CreateSubdirectory("kurwa"); // Tworze podkatalog
                FileInfo[] pliki = di.GetFiles();
                Console.WriteLine("===PODKATALOGI===");
                foreach (DirectoryInfo katalog in katalogi) // Pętla do tablicy DirectoryInfo[] - Wypisuje liste katalogow
                {
                    Console.WriteLine(katalog.Name);
                }
                Console.WriteLine("===PLIKI===");
                foreach (FileInfo plik in pliki) // Pętla do tablicy FileInfo[] - wypisuje liste plików :)
                {
                    Console.WriteLine(plik.Name);
                }
                Console.ReadKey(); */
            string katalog; // Zadanie 26.2
            string nazwa;
            ConsoleKeyInfo klawisz;
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
            Console.WriteLine("Czy chcesz dokonać wyszukiwania? Wciśnij (t) aby szukać, lub inny klawisz, aby przejść dalej");
            klawisz = Console.ReadKey();
            if (klawisz.Key == ConsoleKey.T)
            {
                Console.WriteLine("Podaj nazwe w celu wyszukania, użyj * aby zawężyć pole wyszukiwania:");
                nazwa = Console.ReadLine();
                DirectoryInfo[] dire = di.GetDirectories(nazwa);
                Console.WriteLine("Wyszukiwany jest katalog {0} oraz pliki o haśle {1}", katalog, nazwa);
                foreach (DirectoryInfo dir in dire)
                {
                    Console.WriteLine(dir.Name);
                }
            }
            Console.WriteLine("Czy chcesz wyświetlić zawartość folderu głównego??. Wcisnij (t) aby wyświetlić, lub inny klawisz aby zakończyć program.") // 26.3
            klawisz = Console.ReadKey();
            if (klawisz.Key == ConsoleKey.T)
            {
                FileSystemInfo[] informacja = di.GetFileSystemInfos(); // deklaracja i inicjalizacja
                foreach (FileSystemInfo info in informacja)
                    {
                         Console.Write(" ",info.FullName);
                    }
            }
            Console.ReadKey();
        }
    }
}
