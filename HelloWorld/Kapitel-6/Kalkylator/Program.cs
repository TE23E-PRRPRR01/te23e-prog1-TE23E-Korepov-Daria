/* *************************************************
 * Namn: Miniräknare i konsolen
 * Beskrivning: Ett program för att utföra matematiska operationer
 * Datum: 2025-22-01
*********************************************** */

VisaIntro();

while (true)
{
    VisaMeny();
    string val = Console.ReadLine();

    if (val == "1")
    {
        Addition();
    }
    else if (val == "2")
    {
        Subtraktion();
    }
    else if (val == "3")
    {
        Multiplikation();
    }
    else if (val == "4")
    {
        Division();
    }
    else if (val == "5")
    {
        Console.WriteLine("👋 Tack för att du använde miniräknaren!");
        break;
    }
    else
    {
        Console.WriteLine("⚠️ Ogiltigt val. Försök igen.");
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
    Välkommen till Kalkylatorprogrammet
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
    1. Addition
    2. Subtration
    3. Multiplikation
    4. Divition
    5. Avsluta
    """);
    Console.Write("Ange ditt val: ");
}

/// <summary>
/// Adderar två tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Addition(double tal1, double tal2)
{
    int summa = tal1 + tal2;
    return summa;
}

/// <summary>
/// Subtraherar två tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Subtration(double tal1, double tal2)
{
    int differens = tal1 - tal2;
    return differens;
}