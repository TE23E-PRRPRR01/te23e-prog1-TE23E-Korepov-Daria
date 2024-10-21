﻿// Ett program för kryptering med Ceasar-chiffer
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Ett program för kryptering med Ceasar-chiffer");

// Alfabetet, lista av bokstäver att använda
string alfabetet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";

// Ange en meddelande 
Console.Write("Ange ett meddelande: ");
string meddelande = Console.ReadLine().ToUpper();

//Ange en nyckel (1-9)
Console.Write("Ange en nyckel (1-9): ");
int nyckel = int.Parse(Console.ReadLine());

// Loopa igenom meddelnadet bokstav för bokstav
foreach (char bokstav in meddelande)
{
// Hitta bokstavens position (index)
int index = alfabetet.IndexOf(bokstav);
//Console.WriteLine($"'A' så är index={index}");

// Om bokstaven finns i alfabetet 
if (index != -1)
{
    // Ceasar-krypterin, addera en nyckel (tex 2)
    int nyIndex = index + nyckel;
    //Console.WriteLine($"{index} + {nyckel} = {nyIndex}");

    // Börja om från början efter 29
    if (nyIndex >= alfabetet.Length)
    {
        nyIndex = nyIndex - alfabetet.Length;
    }

    // Plocka ut bokstaven för nyIndex
    char krypteradBokstav = alfabetet[nyIndex];
    //Console.WriteLine($"{nyIndex} är bokstaven {krypteradBokstav}");
    Console.Write(krypteradBokstav);
}
else
{
    //Console.WriteLine($"bokstaven oförändrad: {bokstav}");
    Console.Write(bokstav);
}
}