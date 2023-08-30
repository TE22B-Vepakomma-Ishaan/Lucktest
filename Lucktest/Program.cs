// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
Console.WriteLine("What is your name?");

string Yname = Console.ReadLine();

Console.WriteLine("What is the name of who you hate the the most?");

string Oname = Console.ReadLine();

Console.WriteLine("Where do you live?");

string Location = Console.ReadLine();


Console.WriteLine($"Mirror mirror on the wall, who is fairest of them all?");
Console.WriteLine($"{Oname} is the fairest of them all");
Console.WriteLine("Mirror mirror on the wall, who is lamest of them all");
Console.WriteLine($"That would be your ugly ass, {Yname}, who hails from {Location}.");

Console.ReadLine();