/* *******************************************************************
* ***************************** MAIN *********************************
********************************************************************* */

Console.Clear();
Console.WriteLine("Metoder!");

// Anropa/använd mentoden
SägHej();
SägHej();
SägHej();
SägHej();
SägHej();
SägHej();

// Anropa metoden meny
VisaMeny();

// Anropa metoden RegistreraNamn()
RegistreraNamn();




/* *******************************************************************
* **************************** METODER *******************************
********************************************************************* */

/// <summary>
/// Metod som skriver ut en hälsning
/// </summary>
static void SägHej()
{
    Console.WriteLine("Hej på dig!");
}

// // Anropa SägHej() metoden igen!
//// SägHej();

/// <summary>
/// Metod för tt visa en meny
/// </summary>
static void VisaMeny()
{
    Console.WriteLine("""
    1. Lägg till uppgift
    2. Ta bort uppgift
    3. Skriv ut alla uppgifter
    4. Avsluta
    """);
}

/// <summary>
/// Metod för att ange namn
/// </summary>
static void RegistreraNamn()
{
    Console.Write("Ange namn: ");
    string namn = Console.ReadLine();
    Console.WriteLine(namn);
}