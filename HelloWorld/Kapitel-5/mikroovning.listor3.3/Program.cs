// List 3:3
Console.Clear();

//Skriv ut lista med foreach
List<string> listNamn = ["Cal", "Maljos", "Dante", "Deniss", "Benji"];
Console.WriteLine("Alla namn: ");
foreach (string namn in listNamn)
{
    Console.WriteLine($"- {namn}");
}

//Skriv ut alla årtalen i en lista
List<int> listÅrtal = [1492, 1776, 1914, 1945, 1969];
Console.WriteLine("Alla årtal: ");
foreach (int årtal in listÅrtal)
{
    Console.WriteLine($"- {årtal}");
}

//Skriv ut på en rad
Console.Write("Alla årtal: ");
foreach (int årtal in listÅrtal)
{
    Console.Write($"{årtal}, ");
}
Console.WriteLine();

//Användaren fyller på en lista 
List<string> listNamn = new List<string>();
while (true)
{
    Console.Write("Ange ett namn att lägga till (eller 'exit' för att avsluta): ");
    string input = Console.ReadLine();
    if (input.ToLower() == "exit")
        break;
    listNamn.Add(input);
}
Console.WriteLine($"Alla namn: {string.Join(", ", namn)}");

// Användaren fyller på en lista med djur
List<string> listDjur = ["Panda", "Hund", "Katt", "Häst", ""];
while (true)
{
    Console.Write("Ange ett djur att lägga till (eller 'exit' för att avsluta): ");
    string djur = Console.ReadLine();
    if (djur == "exit")
    {
        break;
    }
    listDjur.Add(djur);
}

//Användaren fyller på en lista med årtal
List<int> listÅrtal = [1492, 1776, 1914, 1945, 1969];
while (true)
{
    Console.Write("Ange ett årtal att lägga till (eller '0' för att avsluta): ");
    int årtal = int.Parse(Console.ReadLine());
    if (årtal == 0)
        break;
    listÅrtal.Add(årtal);
}
Console.WriteLine($"Alla årtal: {string.Join(", ", listÅrtal)}");

// Numrerad lista 
