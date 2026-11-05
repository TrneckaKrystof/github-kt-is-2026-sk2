using System;

namespace VypisRady
{
    class Program
    {
        static void Main(string[] args)
        {
            string pokracovat;

            do
            {
                Console.WriteLine("=== ZÁKLADNÍ PROGRAM ===");
                Console.WriteLine();

                Console.Write("Zadejte hodnotu: ");
                string vstup = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Zadaná hodnota: " + vstup);

                Console.WriteLine();
                Console.Write("Chcete pokračovat? (a/n): ");
                pokracovat = Console.ReadLine();

                Console.WriteLine();

            } while (pokracovat == "a");
        }
    }
}