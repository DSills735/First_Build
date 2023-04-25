using System;
using static System.Formats.Asn1.AsnWriter;

string name = GetName();
var date = DateTime.UtcNow;
 string GetName()
{
    Console.WriteLine("Please type your name!");

    var name = Console.ReadLine();
    return name;
}

Menu(name);


void Menu(string? name)
{
    Console.WriteLine("---------------------------------------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. Right now it is {date}. This is David's Amazing Math Game! So glad you are here to try!\n");
    Console.WriteLine($@"What game would youn like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Exit to Desktop");
    Console.WriteLine("---------------------------------------------------------");

    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition Game!");
            break;
        case "s":
            SubtractionGame("Subtraction Game!");
            break;
        case "m":
            MultiplicationGame("Multiplication Game!");
            break;
        case "d":
            DivisionGame("Division Game!");
            break;
        case "q":
            Console.WriteLine("Goodbye :(");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid Input. Please Try Again");
            break;
    }
}
void AdditionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;

    int firstnumber;
    int secondnumber;

    for(int i=0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        firstnumber = random.Next(1, 9);
        secondnumber = random.Next(1, 9);

        Console.WriteLine($"{firstnumber} + {secondnumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstnumber + secondnumber)
        {
            Console.WriteLine("Your answer was Correct! Type any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Sorry, that is incorrect. Type any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4) Console.WriteLine($"Game Over. Your Final Score is {score}.");
   
    }
}

void SubtractionGame(string message)
{
   
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;

    int firstnumber;
    int secondnumber;

    for(int i=0; i<5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        firstnumber = random.Next(1, 9);
        secondnumber = random.Next(1, 9);

        Console.WriteLine($"{firstnumber} - {secondnumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstnumber - secondnumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Type any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4) Console.WriteLine($"Game Over. Your final score is {score}.");
    }
}
void MultiplicationGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;

    int firstnumber;
    int secondnumber;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        firstnumber = random.Next(1, 9);
        secondnumber = random.Next(1, 9);

        Console.WriteLine($"{firstnumber} * {secondnumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstnumber * secondnumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("That answer was incorrect. Type any key for the next question.");
            Console.ReadLine();
        }
        if (i == 4) Console.WriteLine($"Game Over. Your final score is {score}.");

    }
}
void DivisionGame(string message)
{
    Console.WriteLine(message);

    var score = 0;
    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        var divisionnumbers = GetDivisionNumbers();
        var firstnumber = divisionnumbers[0];
        var secondnumber = divisionnumbers[1];

        Console.WriteLine($"{firstnumber} / {secondnumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstnumber * secondnumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("That answer was incorrect. Type any key for the next question");
            Console.ReadLine();
        }
        if (i == 4) Console.WriteLine($"Game Over. Your final score is {score}.");

    }
}
    


int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstnumber = random.Next(0, 99);
    var secondnumber = random.Next(0, 99);

    var result = new int[2];


    while (firstnumber % secondnumber !=0)
    {
         firstnumber = random.Next(0, 99);
         secondnumber = random.Next(0, 99);

    }
    result[0] = firstnumber;
    result[1] = secondnumber;

    return result;
}
