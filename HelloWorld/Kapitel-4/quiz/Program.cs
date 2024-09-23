Console.Clear();
Console.WriteLine("Välkommen till frågesporten?");

Consle.Write("Vad heter du?");
string namn = Console.ReadLine();

int poäng = 0;

//Fråga 1
Console.WriteLine("""
Fråga 1: Vilken är huvudstaden i Sverige?
a) Stockholm
b) Göteborg
c) Malmö
""");
string svar1 = Fråga("Ditt svar (a, b eller c): ")
if (svar1 == "a")
{
    Consle.WriteLine("Rätt svar!");
    poäng++;
}
else
{
    Consle.WriteLine("Fel svar!");
    poäng--;
}

//Fråga 2
Console.WriteLine("""
Fråga 2: Vad heter Sveriges Kung?
a) Carl  XVI Gustaf
b) Gustav Vasa
c) Olof Skötkonung
""");
string svar2 = Fråga("Ditt svar (a, b eller c): ")
if (svar == "a")
{
    Consle.WriteLine("Rätt svar!");
    poäng++;
}
else
{
    Consle.WriteLine("Fel svar!");
    poäng--;
}

//Fråga 3
Consle.WriteLine("""
Fråga 3: Vilket är världens största hav?
a) Atlanten
b) Stilla havet
c) Indiska oceanen
""");
string svar3 = Fråga("Ditt svar (a, b eller c): ")
if (svar == "b")
{
    Consle.WriteLine("Rätt svar!");
    poäng++;
}
else
{
    Consle.WriteLine("Fel svar!");
    poäng--;
}

//Fråga 4
Consle.WriteLine("""
Fråga 4: Är du pidoraz?
a) Da
b) Net
c) DA NEET 
""");
string svar4 = Fråga("Ditt svar (a, b eller c): ")
if (svar4 == "a")
{
    Consle.WriteLine("Rätt svar!");
    poäng++;
}
else
{
    Consle.WriteLine("Fel svar!");
    poäng--;
}

//Fråga 5
Consle.WriteLine("""
Fråga 5: Är du säker???
a) Mmmm neeet
b) Da
c) Хз
""");
string svar5 = Fråga("Ditt svar (a, b eller c): ")
if (svar5 == "b")
{
    Consle.WriteLine("Rätt svar!");
    poäng++;
}
else
{
    Consle.WriteLine("Fel svar!");
    poäng--;
}

// Resultat
Console.WriteLine("Du fick totalt {poäng} poäng!");

if (poäng == 5)
{
    Console.WriteLine("{namn}, du är en riktig quiz-mästare!");
}
else if (poäng > 0)
{
Console.WriteLine("Bra jobbat, {namn}!");
}
else
{
Console.WriteLine("Bättre lycka nästa gång, {namn}!");
}

// Fråga om användaren vill spela igen
Console.Write("Vill du spela igen? (j/n): ");
string spelaIgenSvar = Console.ReadLine().ToLower();
spelaIgen = (spelaIgenSvar == "j");
