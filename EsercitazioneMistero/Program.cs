using System;
using ClassLibrary1;

namespace EsercitazioneMistero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci un numero");
            int y = int.Parse(Console.ReadLine());
            double risultato = Class1.Mistero3(x, y);
            Console.WriteLine($"il risultato è {risultato}");
            Console.ReadLine();
        }
    }
}
