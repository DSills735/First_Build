Console.WriteLine("Please type your name!");

var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("---------------------------------------------------------");
Console.WriteLine($"Hello {name}. Right now it is {date}. This is David's Amazing Math Game! So glad you are here to try!\n");
Console.WriteLine($@"What game would youn like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the Program");
Console.WriteLine("---------------------------------------------");

Console.ReadLine();