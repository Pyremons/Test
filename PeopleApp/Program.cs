using Packt.Shared;
using static System.Console;

Console.WriteLine("scaphandre");
Console.WriteLine("test");

Person bob = new();
WriteLine(bob.ToString());
bob.Name = "Bob Smith";
bob.DateOfBirth : new DateTime(1965, 12, 22);
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy",
    arg: bob.Name,
    args bob.DateOfBirth);