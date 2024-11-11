// Skapa lista med slumpade tal 

/* *******************************************************
**                        Main                          **
*********************************************************/

// Validera användarens inmatning
Console.Clear();
Console.WriteLine("HaLLOuuu HUMANNN!>:D");

// Deklarera variabler
// Skapa en lista för att spara des slumpade talen
List<int> listaSlumptal = [];

// Fråga igen tills användaren matar in ett giltigt svar
int antal = LäsInHeltal();
Console.WriteLine($"Du vill ha {antal} slumptal!");

int min = LäsInHeltal();
Console.WriteLine($"Du vill ha {min} slumptal!");

int max = LäsInHeltal();
Console.WriteLine($"Du vill ha {max} slumptal!");

for (int i = 0; i < antal; i++)
{
    int slumptal = Random.Shared.Next(min, max + 1);
    Console.WriteLine($"Ditt nya slumptal är {slumptal}");
}

/* *******************************************************
**                    Mina metoder                      **
*********************************************************/

static int LäsInHeltal()
{
    int heltal = 0;
    while (true)
    {
        // Fråga användaren hur många slumptal som skall skapas
        Console.Write("Ange lägsta heltal: ");

        bool lyckades = int.TryParse(Console.ReadLine(), out heltal);
        if (lyckades)
        {
            break;
        }
        else
        {
            Console.WriteLine("Du måste skriva ett heltal");
        }
    }
    return heltal;
}