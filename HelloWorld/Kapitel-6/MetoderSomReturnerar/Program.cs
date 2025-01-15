/* *******************************************************************
* ***************************** MAIN *********************************
********************************************************************* */
// Console.Clear();
// Console.WriteLine("Metoder som returnerar!");
//Använda metoder här:
// int svar = Addera(3, 5);
// Console.WriteLine($"Svaret är {svar}");
// Console.WriteLine(Addera(3, 5));
// Console.WriteLine($"3 + 5 = {Addera(3, 5)}");

//Metoden VändText();
// string namn = "Joan";
// Console.WriteLine($"{namn} baklänges blir {VändText(namn)}");

//Metoden Multiplicera();
double svar = Multiplicera(3, 8);
Console.WriteLine($"3 * 8 = {Multiplicera(3, 8)}");

//Metoden Dividera();
double svar2 = Dividera(24, 8);
Console.WriteLine($"24 / 8 = {Dividera(24, 8)}"); 


Console.Write("Ange ett tal: ");
int nyTal1 = LäsInHeltal();

Console.Write("Ange ett tal: ");
int nyTal2 = LäsInHeltal();

/* *******************************************************************
* **************************** METODER *******************************
********************************************************************* */

//Skapa metoder här:

/// <summary>
/// Summera två tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static int Addera(int tal1, int tal2)  //Signatur  //Byter "void"(=ingenting) till "int" då "return" ska returnera ett tal
{
    int summa = tal1 + tal2;
    return summa;
}

/// <summary>
/// Vänder på texten
/// </summary>
/// <param name="text"></param>
static string VändText(string text)    //"string" itsället för "void" för att den returnerar en string
{
    string omvändText = "";
    for (var i = text.Length - 1; i >= 0; i--)  
    {
        omvändText +=  text[i];
    }
    return omvändText;
}

/// <summary>
/// Multiplicerar tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Multiplicera(double tal1, double tal2)
{
    double produkt = tal1 * tal2;
    return produkt;
}


/// <summary>
/// Dividerar tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Dividera(double tal1, double tal2)
{
    double kvot = tal1 / tal2;
    return kvot;
}



static string Längst(string text1, string text2)
{
    if (text1.Length > text2.Length)
    {
        return text1;
    }
    else
    {
        return text2;
    }
}


/// <summary>
/// Säkert sätt att läsa in tal (utan att det kraschar)
/// </summary>
/// <returns></returns>
static int LäsInHeltal()
{
    int tal = 0;
    while (true)
    {
        //Läs in från användaren
        string textSomBlirTal = Console.ReadLine();
        //Kolla om texten är ett tal
    bool lyckades = int.TryParse(textSomBlirTal, out tal);
    
    if (lyckades == true)
    {
        break;
    }
     else
    {
        Console.WriteLine("Fel! Va god ange ett heltal!");
    }
    }
    return tal;
}