// Använda listor för att slapa/hantera samlingar
Console.Clear();

// Lista på trevliga frukter. tex "äpple", "apelsin", "annanas"
List<string> frukter = ["äpple", "apelsin", "annanas"];

Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// Ändra i listan:
frukter[0] = "banan";
Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// Gå igenom listan = loopa igenom = från första till sista
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}


// Skapa en lista på valfi sak (4st) 
// Slriv ut varje sak på samma rad
// Skapa en lista och använd foreach
List<string> städer = ["Paris", "Moscow", "Beijing", "London", "Milan", "Stockholm", "Rom", "Shanghai", "Seoul", "Tokyo"];

foreach (var stad in städer)
{
    Console.Write($"{stad} ");
}
for (int i = 0; i < städer.Count; i++)
{
    Console.Write($"{städer[i] }");
}


// skapa ett register
Console.Clear();
// en tom lista
List<string> namnlista = [];

// while-loop
while (true)
{
    Console.Write("Ange ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);

    //skriv ut hela listan på en rad
    foreach (var namnet in namnlista)
    {
        Console.Write($"{namnet}, ");
    }
    Console.WriteLine();
}