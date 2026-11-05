using System;

class Program
{
    static void Main(string[] args)
    {
        string again = "a";

        while (again.ToLower() == "a")
        {
            Console.Clear();
            Console.WriteLine("***********************************");
            Console.WriteLine("********* Ciferný součet **********");
            Console.WriteLine("********* Ciferný součin **********");
            Console.WriteLine("***********************************");
            Console.WriteLine("*********** Tomáš Žižka ***********");
            Console.WriteLine("***********************************");
            Console.WriteLine();

            Console.Write("Zadejte celé číslo: ");
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu: ");
            }

            int numberBackup = number;
            int sum = 0;
            int product = 1;
            int digit;

            if (number < 0)
            {
                number = -number;
            }

            if (number == 0)
            {
                sum = 0;
                product = 0;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Průběh rozkladu čísla na cifry (zprava doleva):");

                while (number > 0)
                {
                    digit = number % 10;
                    sum = sum + digit;
                    product = product * digit;

                    Console.WriteLine($"Získána cifra: {digit}");

                    number = number / 10;
                }
            }

            Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine($"Původní číslo:  {numberBackup}");
            Console.WriteLine($"Ciferný součet: {sum}");
            Console.WriteLine($"Ciferný součin: {product}");
            Console.WriteLine("====================================");
            Console.WriteLine();

            Console.Write("Pro opakování programu stiskněte 'a' a potvrďte klávesou Enter: ");
            again = Console.ReadLine() ?? "";
        }
    }
}