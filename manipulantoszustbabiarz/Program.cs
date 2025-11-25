using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj zdanko:");
        string tekst = Console.ReadLine();

        Console.WriteLine($"Ile wazysz ile mierzysz: {tekst.Length}");

        Console.WriteLine("Wielki czy maly hmm? a moze pierwszak? haha");
        Console.WriteLine("Wpisz 'wielki', 'maly' albo 'pierwszak':");
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
        else if (wybor == "pierwszak")
        {
            if (!string.IsNullOrEmpty(tekst))
            {
                string wynik = char.ToUpper(tekst[0]) + tekst.Substring(1).ToLower();
                Console.WriteLine("wielki pierwszak:");
                Console.WriteLine(wynik);
            }
            else
            {
                Console.WriteLine("Eee no nic nie wpisales koleszko...");
            }
        }
        else
        {
            Console.WriteLine("Zly wybur koleszko. Wpisz 'wielki', 'maly' albo 'pierwszak'.");
        }
    }
}
