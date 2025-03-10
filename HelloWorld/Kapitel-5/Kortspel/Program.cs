﻿// Hur man skapar och använder listor
Console.Clear();
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Slumpa kort ur ett kortlek!");

//Skapa en lista kort
//List<string> kortlek = ["Ess", "Tvåa", "Trea", "Fyra", "Femma", "Sexa", "Sjua", "Åtta", "Nia", "Tia", "Knekt", "Dam", "Kung"];

// Ett annat exmpel. lista på tre årtal
//List<int> årtal = [1957, 1969, 1989]; 

List<string> kortlek = ["Ess", "Tvåa", "Trea", "Fyra", "Femma", "Sexa", "Sjua", "Åtta", "Nia", "Tia", "Knekt", "Dam", "Kung"];

int antal = 5;
while (antal > 0)
{
    //Slumpa index = 0-12
    int index = Random.Shared.Next(0, kortlek.Count);
    Console.WriteLine($"Det slumpade index = {index}");

    //PLocka ut det sjunde kortet, index = 6
    string kort = kortlek[index];

    // ta bort kortet ur kortleken
    kortlek.RemoveAt(index);

    //Skriv ut 7:e kortet
    Console.WriteLine($"Det slumpade kortet är {kort}");

    // Räkna ned
    antal--; 
} 
