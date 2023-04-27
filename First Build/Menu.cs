namespace First_Build
{
    internal class Menu
    {
       GameEngine engine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            bool isGameOn = true;
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. Right now it is {date}. This is David's Amazing Math Game!\n");
           
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Exit to Desktop");
                Console.WriteLine("---------------------------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        
                       Helpers.GetGames();
                        break;
                    case "a":
                        engine.AdditionGame("Addition Game!");
                        break;
                    case "s":
                        engine.SubtractionGame("Subtraction Game!");
                        break;
                    case "m":
                        engine.MultiplicationGame("Multiplication Game!");
                        break;
                    case "d":
                        engine.DivisionGame("Division Game!");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye :(");
                        isGameOn = false;
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Please Try Again");
                        break;
                }
            } while (isGameOn);

        }
    }
}
