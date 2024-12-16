Console.Clear();

//Skapa en lista med action-spel
List<string> actionGames = [];
// Skapa en lista med äventyrsspel
List<string> adventureGames = [];


// Användaren fyller på listor
//Användaren fyller på lista med action-spel
Console.WriteLine("Nu ska du fylla i två action-spel i listan:");
for (int i = 0; i < 2; i++)
{
    Console.Write("Ange ett action-spel: ");
    actionGames.Add(Console.ReadLine());
}
//Användaren fyller på lista med äventyrsspel med for-loop
Console.WriteLine("Nu ska du fylla i tre äventyrsspel:");
for (int i = 0; i < 3; i++)
{
    Console.Write("Ange ett äventyrsspel: ");
    actionGames.Add(Console.ReadLine());
}

// Användaren fyller på lista med action-spel med for-loop
Console.WriteLine("Här är de två första action-spelen i listan:");
Console.WriteLine("- Spel 1: " + actionGames[0]);
Console.WriteLine("- Spel 2: " + actionGames[1]);

// Skriv ut två sista äventyrsspel
Console.WriteLine("Här är de två sista äventyrsspelen i listan:");
Console.WriteLine("- Spel 3: " + adventureGames[adventureGames.Count - 2]);
Console.WriteLine("- Spel 4: " + adventureGames[adventureGames.Count - 1]);

// Skriv ut alla spel i varje kategori
Console.WriteLine("Här är alla action-spel i listan:");
foreach (string game in actionGames)
{
    Console.WriteLine("- " + game);
}

Console.WriteLine("Här är alla äventyrsspel i listan:");
foreach (string game in adventureGames)
{
    Console.WriteLine("- " + game);
}

//Skriv ut de tre första spelen i listan mha for-loop
Console.WriteLine("Här är de tre första action-spelen i listan: ");
for (var i = 0; i < 3; i++)
{
    Console.WriteLine($"- Spel 1: {adventureGames[i]}");
    Console.WriteLine($"- Spel 2: ");
}
