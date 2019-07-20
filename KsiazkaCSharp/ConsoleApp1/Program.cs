using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class MainForm : Form
    {
        public MainForm()
        {
            Text = "Okno programu";
            Width = 620;
            Height = 220;
            StartPosition = FormStartPosition.Manual; // Zadanie 35.3
            MainMenu mm = new MainMenu(); // Zadanie 35.4
            MenuItem mi1 = new MenuItem("Menu 1");
            MenuItem mi1p1 = new MenuItem("Pozycja I");
            MenuItem mi1p2 = new MenuItem("Pozycja II");
            MenuItem mi1p3 = new MenuItem("Pozycja III");
            MenuItem mi1p1p1 = new MenuItem("Pozycja 1");
            MenuItem mi1p1p2 = new MenuItem("Pozycja 2");
            MenuItem mi1p1p3 = new MenuItem("Pozycja 3");
            MenuItem mi1p2p1 = new MenuItem("Pozycja 1");
            MenuItem mi1p2p2 = new MenuItem("Pozycja 2");
            MenuItem mi1p2p3 = new MenuItem("Pozycja 3");
            MenuItem mi1p3p1 = new MenuItem("Pozycja 1");
            MenuItem mi1p3p2 = new MenuItem("Pozycja 2");
            MenuItem mi1p3p3 = new MenuItem("Pozycja 3");
            mi1p1.MenuItems.Add(mi1p1p1);
            mi1p1.MenuItems.Add(mi1p1p2);
            mi1p1.MenuItems.Add(mi1p1p3);
            mi1p2.MenuItems.Add(mi1p2p1);
            mi1p2.MenuItems.Add(mi1p2p2);
            mi1p2.MenuItems.Add(mi1p2p3);
            mi1p3.MenuItems.Add(mi1p3p1);
            mi1p3.MenuItems.Add(mi1p3p2);
            mi1p3.MenuItems.Add(mi1p3p3);
            mi1.MenuItems.Add(mi1p1);
            mi1.MenuItems.Add(mi1p2);
            mi1.MenuItems.Add(mi1p3);
            mm.MenuItems.Add(mi1);
            Menu = mm;
        }
        public MainForm(string tytul,int osX, int osY, int wys, int szer) : this()
        {
            Text = tytul;
            Width = szer;
            Height = wys;
            StartPosition = FormStartPosition.Manual; 
            //Application.Run(this);
        }

        /*public static void Main() // Zadanie 35.1
        {
            new MainForm();

        } */
    }
    class Program
    {
        static void Main(string[] args)
        {
            int osX, osY, wysokosc, szerokosc;
            MainForm okno = new MainForm();
            Console.WriteLine("Podaj współrzędne dla osi X");
            osX = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj współrzędne dla osi Y");
            osY = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wysokosc Okna");
            wysokosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj szerokosc Okna");
            szerokosc = int.Parse(Console.ReadLine());
            okno.SetBounds(osX, osY, szerokosc, wysokosc);
            MainForm okno1 = new MainForm("PROGRAM ELO", 420, 220, 1920, 1080);
            Application.Run(okno);
            Application.Run(okno1);
        }
    }
}
