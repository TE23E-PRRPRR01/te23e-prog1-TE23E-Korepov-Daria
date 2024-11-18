// 
Console.Clear();
Console.WriteLine("Hello, World!");


// 1. Skapa en enkel loop + 2. Lägg till ett nummer framför namnet
Console.WriteLine("Vad heter du?");
string name = Console.ReadLine();

Console.WriteLine("Hur många gånger vill du repetera?");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i}. {name}"); 
}

// 3. Låt användaren bestämma antalet repetitioner
int repetitions;

Console.Write("Ange antal repetitioner (1-10): ");
while (int.TryParse(Console.ReadLine(), out repetitions) || repetitions <= 1 || repetitions >= 10)
{
    Console.WriteLine("Ogiltigt värde. Ange ett heltal mellan 1 till 10.");
}

for (int i = 0; i < repetitions; i++)
{
    Console.WriteLine($"{i}. {name}");
}



// 4. Gör beräkningar efter loopen
// Console.Write("Ange ett tal: ");
// while (!double.TryParse(Console.ReadLine(), out double tal))
// {
//     Console.WriteLine("Ogiltigt värde. Ange ett tal.");
// }

// Console.WriteLine($"Multiplicerat med 2: {tal * 2}");
// Console.WriteLine($"Dividerat med 2: {tal / 2}");
// Console.WriteLine($"Adderat med 2: {tal + 2}");
// Console.WriteLine($"Subtraherat med 2: {tal - 2}");
