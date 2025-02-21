using System.ComponentModel;

Console.Clear();
Console.WriteLine("Listor");
Console.WriteLine();

//skapa en lista för pizzarätter
List<string> pizzarätter = [];

// skapa en tom lista för frukter
List<string> frukter = [];

//Skapa en tom lista på skostorlekar
List<int> skostorlekar = [];

// Skapa en lista med tre förnamn
List<string> förnamn = ["Anders", "Elin", "Katarina"];

//Lägg till i listor med .Add()
//Lägg till tre pizzor
pizzarätter.Add("Kebab");
pizzarätter.Add("Margarita");
pizzarätter.Add("Hawaii");

//Lägg till frukter i listan frukter
frukter.Add("Äpple");
frukter.Add("Mandarin");
frukter.Add("Mango");




// Skriv ut alla frukter
foreach (var frukt in frukter)
{
    Console.WriteLine($"Frukt: {frukt}");
}


// Låt användaren mata in en 4:e pizza
Console.WriteLine("Lägg till en ny pizza: ");
string nypizza = Console.ReadLine();
pizzarätter.Add(nypizza);


// Skriv ut alla pizzor
foreach (var pizza in pizzarätter)
{
    Console.WriteLine($"- {pizza}");
}



// Låt användaren mata in en 4:e namn
Console.WriteLine("Skriv in 4:e namnet: ");
string nynamn = Console.ReadLine();
förnamn.Add(nynamn);

//Skriv ut alla namn
foreach (var namn in förnamn)
{
    Console.WriteLine(namn);
}



//Nu låter vi användaren mata in skostorlekar
Console.WriteLine("Ange din skostorlek: ");
int input = int.Parse(Console.ReadLine());
skostorlekar.Add(input);

// Skriv ut skostorlekar
foreach (var skostorlek in skostorlekar)
{
    Console.WriteLine($"* {skostorlek}");
}


// Hur många pizzor har vi?
int antal = pizzarätter.Count;
Console.WriteLine($"Totalt antal pizzor = {antal}");

// hur många frukter?
Console.WriteLine($"Totalt antal frukter = {frukter.Count}");

// hur många namn har vi i listan?
Console.WriteLine($"Det finns totalt {förnamn.Count} i listan");

// skriv ut första namnet
Console.WriteLine($"Första namnet är {förnamn[0]}");

//Skriv ut andra namnet
Console.WriteLine($"Andra namnet är {förnamn[1]}");

//Skriv ut sista namnet
Console.WriteLine($"Sista namnet i listan är {förnamn[förnamn.Count-1]}");

// byta ut första namnet med nåt nytt / annat namn
förnamn[0] = "Ammanda";

// skriv ut första namnet
Console.WriteLine($"Första namnet är {förnamn[0]}");

// byta ut andra namnet med nåt nytt / annat namn
förnamn[1] = "Josefin";

// Be användaren byta ut en pizza
Console.WriteLine("Byt ut en (den första) pizza: ");
string Nypizza = Console.ReadLine();
pizzarätter[0] = nypizza;

// be användaren vilken pizza som skall bytas ut 
// be användaren vad heter nya pizzan
Console.WriteLine("Vilken pizza vill du byta ut? (0, 1, 2): ");
int index = int.Parse(Console.ReadLine());

Console.WriteLine("Vad heter ya pizzan? ");
string Nypizza2 = Console.ReadLine();
pizzarätter[index] = Nypizza2;
