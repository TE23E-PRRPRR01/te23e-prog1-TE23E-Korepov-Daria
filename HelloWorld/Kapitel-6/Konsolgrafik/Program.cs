﻿//Refaktorisering-1

/* *************************************************
 * Namn: Konsolgrafik
 * Beskrivning: Ett program för att rita konsolgrafik
 * Datum: 2025-20-01
 *********************************************** */

VisaIntro();

while (true)
{
    VisaMeny();
    string val = Console.ReadLine();

    // Hantera användarens val
    if (val == "1")
    {
        int tal = LäsInHeltal();

        // Skriv ut fyrkanten
        RitaFyrkant(tal);
    }
    else if (val == "2")
    {
        int tal = LäsInHeltal();

        // Skriv ut triangeln
        RitaTriangel(tal);
    }
    else if (val == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt alternativ, vg försök igen.");
    }
}

/* **********************************************
 *  Metoder 
 ********************************************** */

/// <summary>
/// Visar Intro
/// </summary>
static void VisaIntro()
{
    Console.Clear();
    Console.WriteLine("""
    Program för att rita konsolgrafik
    ===================================
    """);
}

/// <summary>
/// Generell metod för att läsa In Heltal
/// </summary>
/// <returns></returns>
static int LäsInHeltal()
{
    Console.Write("Ange ett heltal: ");
    string talString = Console.ReadLine();
    int tal;
    while (!int.TryParse(talString, out tal))
    {
        Console.Write("Ange ett giltigt heltal: ");
        talString = Console.ReadLine();
    }
    return tal;
}

/// <summary>
/// Skriver ut menyn
/// </summary>
/// <param name="args"></param>
static void VisaMeny()
{
    Console.WriteLine("""
    1. Skriv ut fyrkant
    2. Skriv ut triangel
    3. Avsluta
    """);
    Console.Write("Välj ett alternativ: ");
}

/// <summary>
/// Ritar en fyrkant
/// </summary>
/// <param name="tal"></param>
static void RitaFyrkant(int tal)
{
    for (int i = 0; i < tal; i++)
    {
        for (int j = 0; j < tal; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Ritar en triangel
/// </summary>
/// <param name="tal"></param>
static void RitaTriangel(int tal)
{
    for (int i = 0; i < tal; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}