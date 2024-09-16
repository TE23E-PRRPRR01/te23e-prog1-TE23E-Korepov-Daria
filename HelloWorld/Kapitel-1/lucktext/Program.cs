Console.Clear();

Console.WriteLine("Здрастуй жопамир!");

Console.WriteLine("Ange förnamn:");
string firstname = Console.ReadLine();

Console.WriteLine("Ange efternamn:");
string lastname = Console.ReadLine();

Console.WriteLine("Ange datum:");
string date = Console.ReadLine();

Console.Write("Ange månad:");
string month = Console.ReadLine();

if (firstname == "Daria" && lastname == "Korepov" && date == "7" && month == "7")
{
    Console.WriteLine("Добро пожаловать Мама!");
}
if (firstname != "Daria" && lastname != "Korepov" && date != "7" && month != "7")
{
    Console.WriteLine("ТЫ ПИДАР!:O");
}