/* *******************************************************************
* ****************************** MAIN ********************************
********************************************************************* */
Console.Clear();
Console.WriteLine("Metoder med parametrar!");

// Skriva ut ett meddelande vertikalt

string meddelande = "Måndag!";
// SkrivVertikalt(meddelande);

// Skriva ut ett meddelande nr 2
string meddelande1 = "Tisdag är bättre!";
// SkrivVertikalt(meddelande1);

// Skriva ut ett meddelande nr 3
string meddelande2 = "Onsdag är ännu bättre!";
// SkrivVertikalt(meddelande2);


//Rita ut en fyrkant med sidlängd 3
// RitaKvadrat(3);
// Console.WriteLine();
// RitaKvadrat(4);

// Testa metoden UpprepaText
// UpprepaText("Hej", 3);
// UpprepaText("Hallå Hallå", 2);
// UpprepaText("HEJDÅ SES ALDRIG IGEN", 1);

//Testa metoden OmvandlaCTillF()
//OmvandlaCTillF(37);

//Testa metoden KastaTärning()
KastaTärning(6);


/* *******************************************************************
* **************************** METODER *******************************
********************************************************************* */
/// <summary>
/// Skriv ett meddelande vertikalt
/// </summary>
/// <param name="meddelande"></param>
static void SkrivVertikalt(string meddelande)
{
    for (var i = 0; i < meddelande.Length; i++)  // 0 -> 6
    {
        Console.WriteLine(meddelande[i]);
    }
}


static void RitaKvadrat(int sidlängd)
{
    for (int i = 0; i < sidlängd; i++)
    {
        for (int j = 0; j < sidlängd; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Upprepar text
/// </summary>
/// <param name="text"></param>
/// <param name="antal"></param>
static void UpprepaText(string text, int antal)
{
    for (int i = 0; i < antal; i++)
    {
        Console.WriteLine(text);
    }
}

/// <summary>
/// Omvandlar temperatur celsius till fahrenheit
/// </summary>
/// <param name="celsius"></param>
static void OmvandlaCTillF(int celsius)
{
    int fahrenheit = celsius * 9/5 + 32;
    Console.WriteLine($"{celsius} grader Celsius motsvarar {fahrenheit} grader Fahrenheit");
}

/// <summary>
/// Skriver ut ett slumptal
/// </summary>
/// <param name="tal"></param>
static void KastaTärning(int antal)
{
    for (int i = 0; i < antal; i++)
    {
        Console.WriteLine($"Tärningen visar {Random.Shared.Next(1,7)}");
    }
}
