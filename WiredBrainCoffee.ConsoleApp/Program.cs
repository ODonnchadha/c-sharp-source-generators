using WiredBrainCoffee.ConsoleApp.Model;

Console.WriteLine("---------------------------------------");
Console.WriteLine("  Wired Brain Coffee - Person Manager  ");
Console.WriteLine("---------------------------------------");
Console.WriteLine();

var person = new Person
{
    FirstName = "X",
    MiddleName = "Y",
    LastName = "Z"
};

var personAsString = person.ToString();

Console.WriteLine(personAsString);

Console.ReadLine();