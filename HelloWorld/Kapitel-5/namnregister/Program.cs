// Ett litet namnregister
Console.Clear();
Console.WriteLine("Ett litet namnregister");
List<string> namnlista = [];
// Programloopen
while (true)
{
    // visa en meny
    Console.WriteLine("""
1. Registrera namn
2. Skriva ut alla namn
3. Avsluta programet
Ange ditt val:
""");
    string val = Console.ReadLine();

    if (val == "1")
    {
        while (true)
        {
            Console.WriteLine("Lägg in namn i register");
            int namn = Console.ReadLine();
            namnlista.Add(namn);
        }
    }

    else if (val == "2")
    {
        foreach (var namnet in namnlista)
        {
            Console.Write($"namnet");
        }
        Console.WriteLine();
    }

    else if (val == "3")
    {
        Console.WriteLine("Programmet avslutas...");
        break;
    }
}