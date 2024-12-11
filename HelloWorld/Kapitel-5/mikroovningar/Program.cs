// List 1:3
Console.Clear();

// Skapa lista med 5 namn
List<string> namnlista = ["Sophie", "Katja", "Veronika", "Ellen", "Elsa", "Dante"];
Console.WriteLine($"Mina kompisar är: {string.Join(",", namnlista)}");
// skapa en lista med 5 orter
List<string> orterlista = ["Stockholm", "Göteborg", "Malmö", "Uppsala", "Lund"];

//viktig årtal
List<int> listÅrtal = [1492, 1776, 1914, 1945, 1969];
Console.WriteLine($"Fem viktiga årtal är: '{string.Join("','", listÅrtal)}'");

// Visa första och sista objektet i en lista
Console.WriteLine("First name: " + namnlista[0]);
Console.WriteLine("last name: " + namnlista[4]);

// Lista med 5 dryckor
List<string> listDryckor = ["7 UP", "Red Bull", "Vatten med Citron", "Kaffe", "Vitamine"];
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(listDryckor[0]);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(listDryckor[1]);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(listDryckor[2]);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(listDryckor[3]);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(listDryckor[4]);
Console.ResetColor();

//Skapa en lista med födelseår
List<int> BDYlist = [1995, 1997, 2001, 2005, 2007];
Console.WriteLine(string.Join($"Födelseår: '{string.Join("','", BDYlist)}'"));

// Lägg till ett namn baserat på en variabel
