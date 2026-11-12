using System.Drawing;

string again = "a";

while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("********************************");
    Console.WriteLine("***** Vykreslení obdélníku *****");
    Console.WriteLine("********************************");
    Console.WriteLine("********* Tomáš Žižka **********");
    Console.WriteLine("********************************");
    Console.WriteLine();

    // 1. Bezpečné načtení šířky s kontrolou na kladnou hodnotu
    Console.Write("Zadejte šířku obrazce (přirozené číslo): ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
    {
        Console.Write("Šířka musí být celé kladné číslo větší než 0. Zadejte znovu: ");
    }

    // 2. Bezpečné načtení výšky s kontrolou na kladnou hodnotu
    Console.Write("Zadejte výšku obrazce (přirozené číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.Write("Výška musí být celé kladné číslo větší než 0. Zadejte znovu: ");
    }

    Console.WriteLine();
    Console.WriteLine($"Vykresluji obrazec o rozměrech {width} × {height}:");
    Console.WriteLine();

    // 3. Jádro algoritmu: Vnořený cyklus pro 2D rastr
    // Vnější cyklus počítá řádky (shora dolů)
   // Vnější cyklus: i jde od 1 do zadané velikosti
for (int i = height; i >= 1; i--)
{
    // Nastavení barvy podle řádku
    if (i % 2 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }

    for (int j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}

Console.ResetColor();

    // 4. Dotaz na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte Enterem: ");
    again = Console.ReadLine() ?? "";
}