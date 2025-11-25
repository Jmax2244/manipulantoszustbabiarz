/* 
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
*/

/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj jakis tekscik byniu");
        string tekst = Console.ReadLine();

        string czystyjakperuwianskikoks = tekst.Trim();

        Console.WriteLine($"Wpisane: {czystyjakperuwianskikoks}");
        Console.WriteLine($"Długonosc: {czystyjakperuwianskikoks.Length}");

        if (czystyjakperuwianskikoks.Length > 0)
        {
            Console.WriteLine($"Pierwsza litera: {czystyjakperuwianskikoks[0]}");
            Console.WriteLine($"Ostatnia litera: {czystyjakperuwianskikoks[czystyjakperuwianskikoks.Length - 1]}");
        }
        else
        {
            Console.WriteLine("Ale mordo nie wpisales nic");
        }
    }
}
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj jakis tekscik dobry mordo");
        string tekst = Console.ReadLine();

        Console.WriteLine("Podaj znak do policzonka (1 literka):");
        string znakString = Console.ReadLine();

        if (string.IsNullOrEmpty(znakString) || znakString.Length != 1)
        {
            Console.WriteLine("Miales podac tylko jeden znak koleszko");
            return;
        }

        char znak = znakString[0];
        int licznik = 0;

        for (int i = 0; i < tekst.Length; i++)
        {
            if (tekst[i] == znak)
            {
                licznik++;
            }
        }

        Console.WriteLine($"Znak '{znak}' wystepuje tutaj {licznik} razy.");
    }
}
