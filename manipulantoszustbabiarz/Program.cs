using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj zdanko:");
        string tekst = Console.ReadLine();

        Console.WriteLine($"Ile mierzysz ile wazysz: {tekst.Length}");

        Console.WriteLine("Wielkie litery:");
        Console.WriteLine(tekst.ToUpper());

        Console.WriteLine("Małe literki sigma");
        Console.WriteLine(tekst.ToLower());
    }
}
