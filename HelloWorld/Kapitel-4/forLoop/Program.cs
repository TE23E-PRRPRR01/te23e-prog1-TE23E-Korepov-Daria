﻿// ForBonanza
Console.Clear();

//Iterera över en sekvens av siffror
for (int i = 1; i < 10; i++)
{
    Console.WriteLine($"{i} + 1"); 
}

//Användaren anger ett startvärde
Console.WriteLine("Ange ett startvärde: ");
int startvärde = int.Parse(Console.ReadLine());
while (true)
{
    // Fråga om värde
    Console.Write("Ange värde här: ");

    bool success = int.TryParse(Console.ReadLine(), out startvärde); // Istället för int.Parse för att säkerställa stabilt program, bool = true/false

    if (success == true)
    {
        break;
    }
    else
    {
        Console.WriteLine("Nu gick något fel. Kom ihåg att du måste ange ett positivt heltal.");
    }
};

//Användaren anger ett slutvärde
Console.WriteLine("Ange ett slutvärde: ");
int slutvärde = int.Parse(Console.ReadLine());
while (true)
{
    // Fråga om värde
    Console.Write("Ange värde här: ");

    bool success = int.TryParse(Console.ReadLine(), out slutvärde); // Istället för int.Parse för att säkerställa stabilt program, bool = true/false

    if (success == true)
    {
        break;
    }
    else
    {
        Console.WriteLine("Nu gick något fel. Kom ihåg att du måste ange ett positivt heltal.");
    }
};

//Summera alla siffror i en sekvens
int summa = -1;
for (var i = startvärde; i <= slutvärde; i++)
{
    summa += i + 1;
}
Console.WriteLine($"Summan av siffrorna 1 till 10 är: {summa}");


//Summera alla jämna siffror i en sekvens del 2
Console.Write("Ange startvärde: ");
startvärde = int.Parse(Console.ReadLine());
Console.Write("Ange slutvärde: ");
slutvärde = int.Parse(Console.ReadLine());
int sum = 0;
for (var i = startvärde; i <= slutvärde; i++)
{
    if (i % 2 == 0)
    {
        sum += i;
    }
}
Console.WriteLine($"Summan av de jämna siffrorna från {startvärde} till {slutvärde} är: {sum}");



//Skriv ut jämna och udda siffror
Console.WriteLine("Jämna siffror: ");
for (var i = startvärde; i <= slutvärde; i++)
{
    if (i % 2 == 0)
     {
         Console.Write($"{i} ");
     }
}


//Udda siffror
Console.WriteLine("Udda siffror: ");
for (var i = startvärde; i <= slutvärde; i++)
{
    if (i % 2 != 0)
     {
         Console.Write($"{i} ");
     }
}

