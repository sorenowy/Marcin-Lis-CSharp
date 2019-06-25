using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void SzyfrCezara(string szyfr) // Metoda wykonujaca szyfrowanie metoda cezara - mozna ja uzupelnic wedle zyczenia :)
        {
            string haslo;
            haslo = szyfr.Replace('a', 'k').Replace('b', 'j').Replace('c', 'i').Replace('d', 'l').Replace('e', 'z');
            Console.WriteLine("Oryginalny wprowadzony tekst to:" +szyfr);
            Console.WriteLine("Zaszyfrowany tekst : " + haslo);
        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            int liczba1, liczba2;
            /*do
            {
                Console.WriteLine("Prosze nacisnac klawisz Q.");  // Zadanie 25.1
                keyInfo = Console.ReadKey();
                if (keyInfo.Key != ConsoleKey.Q)
                {
                    Console.WriteLine("\n TO nie jest klawisz Q. Proszę nacisnąć klawisz Q.");
                }
            }
            while (keyInfo.Key != ConsoleKey.Q);
            Console.WriteLine("Dziękuję za nacisniecie klawisza Q.");
            Console.ReadKey(); */
            /* try
            {
                do
                {
                    Console.WriteLine("Czy chcesz uruchomić program do używania szyfru Cezara. Wciśnij Enter aby kontynuować, lub Escape aby zakończyć.");
                    keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("Podaj kod który chcesz przekształcić za pomoca kodu Cezara:");
                        SzyfrCezara(Console.ReadLine());
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wcisnąłęś zły klawisz.");
                        Console.ReadKey();
                    }
                }
                while (keyInfo.Key != ConsoleKey.Escape);
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Dziekuje za skorzystanie z programu ! ");
                Console.ReadKey(); // Zadanie 25.2
            } */
            /* Console.WriteLine("Wprowadzaj linie tekstu. Wpisz 'quit' aby zakonczyc.");
            string line;
            do
            {
                line = Console.ReadLine();
                Console.WriteLine("wprowadzona linia to : {0}", line);
                
            }
            while (line != "quit"); // Zadanie 25.3 */
            /* Console.WriteLine("podaj wartosc jednej z cyfr w celu mnożenia:");
            liczba1 = int.Parse(Console.ReadLine());
            while (liczba1 < 0)
            {
                Console.WriteLine("Wprowadziłeś błędnie liczbę 1, wprowadź liczbę rzeczywistą:");
                liczba1 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("podaj wartosc drugiej z cyfr w celu mnożenia:");
            liczba2 = int.Parse(Console.ReadLine());
            while (liczba2 < 0)
            {
                Console.WriteLine("Wprowadziłeś błędnie liczbę 2, wprowadź liczbę rzeczywistą:");
                liczba2 = int.Parse(Console.ReadLine());
            }
            int wynik = liczba1 * liczba2;
            Console.WriteLine("Wynik działania to : " + wynik);
            Console.ReadKey(); // Zadanie 25.4 */
            try
            {
                string ciagznakow = "1,2,3,5,6,11,22";
                Console.WriteLine("Ciąg znaków zawiera znaki : " + ciagznakow);
                Convert.ToInt32(ciagznakow);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            Console.ReadKey();
        }
    }
}
