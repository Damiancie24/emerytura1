using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;


namespace ConsoleAppWithVB
{
    class Program
    {
        static void Main(string[] args)
        {
                //tu piszemy kod
            Interaction.MsgBox("Program Emerytura");



            Console.WriteLine("Program EMERYTURA");
                // Console.Write("Podaj swoje imię: ");
            string imie;
            //string imie = Console.ReadLine().Trim().ToUpper();
            //imie = imie.Trim();
            imie = Interaction.InputBox("Podaj Imie", "Emerytura").Trim();

            string pierwszaLitImie = imie.Substring(0, 1);
            string resztaLitImie = imie.Substring(1);
            imie = pierwszaLitImie.ToUpper() + resztaLitImie.ToLower();



                //Console.Write("Podaj swoje nazwisko: ");


            String nazwisko; // = Console.ReadLine(); //.Trim().ToLower();
            nazwisko = Interaction.InputBox("Podaj Podaj nazwisko", "Emerytura").Trim();
                //nazwisko.Trim();

            string perwszaLitera = nazwisko.Substring(0, 1);
            string reszta = nazwisko.Substring(1);
            nazwisko = perwszaLitera.ToUpper() + reszta.ToLower();

                //Console.WriteLine("Witaj, " + imie +" " + nazwisko + "!");

                //Console.WriteLine("witaj, {0} {1}!", nazwisko, imie);  //formatted string

                //Console.WriteLine($"Witaj, {imie} {nazwisko}!");

                //Console.Write("Podaj swój wiek ");

            int wiek;
            string s = Interaction.InputBox("Podaj wiek", "Emerytura"); //Console.ReadLine();
            wiek = int.Parse(s);

            Interaction.MsgBox($"Witaj {imie} {nazwisko}! Masz: {wiek} lat.");

                // Console.WriteLine($"Masz: {wiek} lat."); // Preferowany zapis WrightLine , sklejania twkstu

                //jezeli wiek jest wiekszy od 67 t jesteś emerytem
                //a w przeciwnym wypadku zostało ci 67 - wik

            if (wiek >= 67)
            {
                    //Console.WriteLine("jesteś emerytem");
                Interaction.MsgBox("jesteś emerytem");
            }
            else
            {
                    //Console.WriteLine($"Do emerytury zostało ci {67 - wiek}");
                Interaction.MsgBox($"Do emerytury zostało Ci {67 - wiek} Lat");
            }










        }
    }
}
