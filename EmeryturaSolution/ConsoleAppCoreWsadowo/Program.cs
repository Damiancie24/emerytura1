
// Aplikacja w .Net core
// Aplikacja działa w trybie wsadowym wykorzystuje parametry 
//przekazywane w linii komend
// przzykład uzucia: app.exe Imie Nazwisko Wiek

using System;




namespace ConsoleAppCoreWsadowo
{
    class Program
    {
        const int WiekEmerytalny = 67;

        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine(" za mało parametrów. Wymagane 3");
                return;
            }
               



            string imie = args[0];
            string nazwiako = args[2];
            int wiek = int.Parse(args[2]);



            Console.WriteLine($"Witaj, {imie} {nazwiako}!");

            Console.WriteLine($"Masz {wiek} lat");
            if(wiek >= WiekEmerytalny )
            {
                Console.WriteLine("Jesteś emerytem");
            }
            else
            {
                Console.WriteLine($"do emerytury zostało ci {WiekEmerytalny - wiek}");
            }



        }
    }
}
