/* *************************************************
 * Namn: Meddelandeprogram
 * Beskrivning: Ett program för att spara och läsa meddelanden
 * Datum: 2025-22-01
 *********************************************** */

VisaIntro();

string filnamn = "meddelanden.txt";
while (true)
{
    VisaMeny();
    string val = Console.ReadLine();

    if (val == "1")
    {
        SparaFleraMeddelande(filnamn);
    }
    else if (val == "2")
    {
        LäsaMeddelande(filnamn);
    }
    else if (val == "3")
    {
        RaderaFil(filnamn);
    }
    else if (val == "4")
    {
        Console.WriteLine("Tack för idag!");
        break;
    }
    else
    {
        Console.WriteLine("Du valde ett ogiltigt alternativ. Försök igen!");
    }
}



/* ************************************************
 * **************** Metoder ***********************
 ************************************************* */

/// <summary>
/// Visar en presentation av programmet
/// </summary>
static void VisaIntro()
{
    Console.Clear();
    Console.WriteLine("""
    ===================================
    Välkommen till meddelandeprogrammet
               ~2025-22-01~
    ===================================
    """);
}

/// <summary>
/// Skriver ut en meny med tre alternativ och läser in användarens val
/// </summary>
/// <returns>Användarens val</returns>
static void VisaMeny()
{
    Console.WriteLine("""
    1. Spara meddelande
    2. Läsa meddelande
    3. Radera fil
    4. Avsluta
    """);
    Console.Write("Välj ett alternativ: ");
}

/// <summary>
/// Sparar flera meddelande till en fil
/// </summary>
/// <param name="filnamn">Namnet på filen</param>
static void SparaFleraMeddelande(string filnamn)
{
    Console.Write("Skriv in meddelande du vill spara: ");
    string texten = Console.ReadLine();
    File.AppendAllText(filnamn, texten);  //Lägger till text till en befintlig fil.
    Console.WriteLine("Meddelandet sparades.");
}

/// <summary>
/// Läser meddelande från en fil
/// </summary>
/// <param name="filnamn">Namnet på filen</param>
static void LäsaMeddelande(string filnamn)
{
    if (File.Exists(filnamn))   //Kontrollera om filen finns innan du läser innehållet.
    {
        string texten = File.ReadAllText(filnamn);
        Console.WriteLine("Meddelandet: ");
        Console.WriteLine(texten);
    }
    else
    {
        Console.WriteLine("Filen existerar ej!");
    }
}

/// <summary>
/// Raderar en befintlig fil
/// </summary>
/// <param name="filnamn"></param>
static void RaderaFil(string filnamn)
{
    Console.Write($"Är du säker på att du vill radera filen {filnamn}? (j/n): ");
    string svar = Console.ReadLine().ToLower();
    if (svar == "j")
    {
        File.Delete(filnamn);
        Console.WriteLine("Filen raderades.");
    }
    else
    {
        Console.WriteLine("Filen raderades ej.");
    }
}