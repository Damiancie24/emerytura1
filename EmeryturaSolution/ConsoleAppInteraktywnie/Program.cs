using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInteraktywnie
{
    class Program
    {
        static void Main(string[] args)
        {
            //tu piszemy kod

            Console.WriteLine("Program EMERYTURA");
            Console.Write("Podaj swoje imię: ");
            string imie = Console.ReadLine().Trim().ToUpper();
            //imie = imie.Trim();
            
            

            Console.Write("Podaj swoje nazwisko: ");
            String nazwisko = Console.ReadLine(); //.Trim().ToLower();
            string perwszaLitera = nazwisko.Substring(0,1);
            string reszta = nazwisko.Substring(1);
            nazwisko = perwszaLitera.ToUpper() + reszta.ToLower();
           
            //Console.WriteLine("Witaj, " + imie +" " + nazwisko + "!");

            //Console.WriteLine("witaj, {0} {1}!", nazwisko, imie);  //formatted string

            Console.WriteLine($"Witaj, {imie} {nazwisko}!");

            Console.Write("Podaj swój wiek ");

            int wiek;
            string s  = Console.ReadLine();
            wiek = int.Parse(s);

            Console.WriteLine($"Masz: {wiek} lat."); // Preferowany zapis WrightLine , sklejania twkstu

            //jezeli wiek jest wiekszy od 67 t jesteś emerytem
            //a w przeciwnym wypadku zostało ci 67 - wik

            if (wiek >= 67)
            {
                Console.WriteLine("jesteś emerytem");
            }
            else
            {
                Console.WriteLine($"Do emerytury zostało ci {67 - wiek}");
            }
            





            
           
            


        }
    }
}
