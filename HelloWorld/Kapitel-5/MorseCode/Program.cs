// Morsecode Translater 
Console.Clear();
Console.WriteLine("En liten morsecode app");

//Två listor
List<string> alfabetet = [ "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
            "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", 
            "4", "5", "6", "7", "8", "9" ];
List<string> morsekod = [ ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
            "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
            "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", 
            "--..", ".--.-", ".-.-", "---.", "/", ".----", "..---", "...--", 
            "....-", ".....", "-....", "--...", "---..", "----.", "-----" ];

// Läs in en text
Console.WriteLine("Ange en meddelande: ");
string meddelande = Console.ReadLine();

// Gå igenom meddelandet bokstav för bokstav (loop)
foreach (char bokstav in meddelande)
{
    // Uppslag i alfabatet efter index
    int index = alfabetet.IndexOf(bokstav.ToString());

    // Hittar morsetecken (A-Ö)?
    if (index >= 0)
    {
        //Console.WriteLine($"{bokstav} finns på index {index}");

        //Plocka ut morsetecknet för detta index
        string morsetecken = morsekod[index];
        //Console.WriteLine($"{bokstav} är {morsetecken}");
        Console.Write($"{morsetecken} ");

        // Spela morse som ljud-beep
        // Tex D = "-.."
        // Dvs loopa igenom morsetecknet 
        foreach (char signal in morsetecken)
        {
            if (signal == '.') // '.
            {
                // 1000Hz och 200ms
                Console.Beep(1000, 200);
            }
            else // '-'
            {
                Console.Beep(1000, 600);
            }
        }

        //Paus i koden
        Thread.Sleep(200);
    }
    else
    {
        Console.WriteLine("?");
    }


}





