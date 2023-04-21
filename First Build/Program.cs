Console.WriteLine("Please type your name!");

var name = Console.ReadLine();
var date = DateTime.UtcNow;

Console.WriteLine("---------------------------------------------------------");
Console.WriteLine($"Hello {name. ToUpper()}. Right now it is {date}. This is David's Amazing Math Game! So glad you are here to try!\n");
Console.WriteLine($@"What game would youn like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Exit to Desktop");
Console.WriteLine("---------------------------------------------------------");

var gameSelected = Console.ReadLine();

if (gameSelected.Trim().ToLower() == "a")
{
    AdditionGame("Addition Game Selected!");
}
else if (gameSelected.Trim().ToLower() == "s")
{
    SubtractionGame("Subtraction Game Selected!");
}
else if (gameSelected.Trim().ToLower() == "m")
{
    MultiplicationGame("Multiplication Game Selected!Q");
}
else if (gameSelected.Trim().ToLower() == "d")
{
    DivisionGame("Division Game Selected!");
}
else if (gameSelected.Trim().ToLower() == "q")
{
    Console.WriteLine("Goodbye :(");
    Environment.Exit(1);
}
else
{
    Console.WriteLine("Invalid Input. Please Try Again");
}

void AdditionGame(string message)
{
    Console.WriteLine(message);
}
    
void SubtractionGame(string message)
{
    Console.WriteLine(message);
}
void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}
void DivisionGame(string message)
{
    Console.WriteLine(message);
}
    