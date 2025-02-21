/* *************************************************
 * Namn: CeasarKryptoApp
 * Beskrivning: Ett program för Ceasar-kryptering
 * Datum: 2021-09-01
 *********************************************** */
VisaIntro();

string filnamn = "meddelande.txt"; 
while (true)
{
    VisaMeny();
    string val = Console.ReadLine();
    

}



/* ************************************************
 * **************** Metoder ***********************
 ************************************************* */

/// <summary>
/// Visar Intro
/// </summary>
static void VisaIntro()
{
    Console.Clear();
    Console.WriteLine("""
    ===================================
    Välkommen till Ceasar-krypto App!
               ~2025-27-01~
    ===================================
    """);
}

/// <summary>
/// Skriver ut en meny med tre alternativ och läser in användarens val
/// </summary>
static void VisaMeny()
{
    Console.WriteLine("""
    Visa huvudmeny:
    1. Kryptera meddelande
    2. Avkryptera meddelande
    3. Avsluta programmet
    """);
    Console.WriteLine("Ange ditt val: ");
}


static void KrypteraMeddelande(string filnamn)
{
    Console.WriteLine("Skriv in meddelande du vill kryptera: ");
    string texten = Console.ReadLine();
    
}