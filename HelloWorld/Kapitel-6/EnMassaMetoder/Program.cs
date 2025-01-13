/* *******************************************************************
* ****************************** MAIN ********************************
********************************************************************* */

Console.Clear();
Console.WriteLine("Hej hej Metoder!");

SägHejNamn("Daria");
SägHejNamn("Cecilia");
SägHejNamn("");
SägHejNamn("Liza");
KvadreraTal(2);


/* *******************************************************************
* **************************** METODER *******************************
********************************************************************* */

/// <summary>
/// Skriv ut hälsning
/// </summary>
/// <param name="namn">Namnet</param>
static void SägHejNamn(string namn)
{
    Console.WriteLine($"Hej på dig {namn}!");
}

/// <summary>
/// Metoden som skriver ett tal i kvadrat
/// </summary>
/// <param name="tal"></param>

static void KvadreraTal(int tal)
{
    Console.WriteLine($"{tal} i kvadrat = {tal * tal}");
}
