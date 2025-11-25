using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj zdanko:");
        string tekst = Console.ReadLine();

        Console.WriteLine($"Ile wazysz ile mierzysz: {tekst.Length}");

        Console.WriteLine("Wielki czy maly hmm?");
        Console.WriteLine("Wpisz 'wielki' albo 'maly':");
        string wybor = Console.ReadLine().ToLower().Trim();

        if (wybor == "wielki")
        {
            Console.WriteLine("Tekst wielkimi literami:");
            Console.WriteLine(tekst.ToUpper());
        }
        else if (wybor == "maly")
        {
            Console.WriteLine("Tekst malymi literami:");
            Console.WriteLine(tekst.ToLower());
        }
        else
        {
            Console.WriteLine("Zly wybur koleszko Wpisz 'wielki' lub 'maly'.");
        }
    }
}
