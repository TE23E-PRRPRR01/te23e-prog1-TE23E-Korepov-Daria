Console.WriteLine("Slumpa Städer!");
Console.Clear();

List<string> kortlek = ["Stockholm", "Uppsala", "Göteborg", "Malmö", "Halmstad", "Norrköping", "Trelleborg", "Vänersborg", "Enköping", "Linköping"];

int antal = 5;
while (antal > 0)
{
    //Slumpa index = 0-10
    int index = Random.Shared.Next(0, 11);
    Console.WriteLine($"Det slumpade index = {index}");

    //PLocka ut det sjunde kortet, index = 6
    string kort = kortlek[index];

    //Skriv ut 7:e kortet
    Console.WriteLine($"Det slumpade kortet är {kort}");

    // Räkna ned
    antal--; 
} 