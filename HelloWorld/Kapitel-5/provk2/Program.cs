Console.Clear();
Console.WriteLine("Filmregister");

//Del 1

// LIsta för att lagra filmer
List<string> listFilm = [];

//Användaren får lägga till filmer. Programmet skriver ut alla filmer.
Console.WriteLine("*** Filmregistern ***");
Console.Write("Ange antal filmer per sida (3-5): ");
string antalText = Console.ReadLine();
int antal = 0;
while (true)
{
    bool success = int.TryParse(antalText, out antal);
    if (success)
    {
        break;
    }
    else
    {
        Console.WriteLine("Fel! Va god mata ett heltal!");
    }
}

// Programloop
while (true)
{
    // visa en meny
    Console.WriteLine("""
1. Lägg till filmer
2. Lista alla filmer
3. Sök en film
4. Avsluta
Välj ett alternativ:
""");
    string val = Console.ReadLine();

    if (val == "1")
    {
        // Lägg till filmer i listan
        for (var i = 0; i < antal; i++)
        {
            Console.Write("Skriv ner en film: ");
            listFilm.Add(Console.ReadLine());
        }
    }
    else if (val == "2")
    {
        // Skriv ut alla filmer i listan
        foreach (var filmnamn in listFilm)
        {
            Console.WriteLine($"- {filmnamn}");
        }


        // Console.WriteLine("Här är alla filmer i listan: ");
        // Console.BackgroundColor = ConsoleColor.Blue;
        // Console.Write(string.Join(", ", listFilm));
        // Console.BackgroundColor = ConsoleColor.Black;
    }
    else if (val == "3")
    {
        //Sök en film
        Console.WriteLine("Ange en film att söka efter (första bokstaven): ");
        string bokstav = Console.ReadLine();
        foreach (var filmnamn in listFilm)
        {
            // Kolla om varje film börjar på bokstaven
            if (filmnamn.StartsWith(filmnamn))
            {
                Console.WriteLine($"- {filmnamn}");
            }
        }
    }
    else if (val == "4")
    {
        Console.WriteLine("Tack för idag!");
        break;
    }
    else
    {
        Console.WriteLine("Fel val. Försök igen!:P");
    }
}