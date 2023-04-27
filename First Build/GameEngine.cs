namespace First_Build
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var Score = 0;

            int firstnumber;
            int secondnumber;



            for (int i = 0; i < 5; i++)
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
                    Score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Sorry, that is incorrect. Type any key for the next question.");
                    Console.ReadLine();
                }
                    if (i == 4) Console.WriteLine($"Game Over. Your Final Score is {Score}. Press any key to return to the menu.");
                    Console.ReadLine();
                

            }
            Helpers.AddToHistory(Score, "Addition");
            

        }

        internal void SubtractionGame(string message)
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

                if (i == 4) Console.WriteLine($"Game Over. Your final score is {score}. Press any key to return to the menu.");
                Console.ReadLine();

            }

            Helpers.AddToHistory(score, "Subtraction");
        }

        internal void MultiplicationGame(string message)
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
                if (i == 4) Console.WriteLine($"Game Over. Your final score is {score}. Press any key ot return to the menu.");
                Console.ReadLine();


            }

            Helpers.AddToHistory(score, "Multiplication");
        }

        internal void DivisionGame(string message)
        {
            Console.WriteLine(message);

            var score = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                var divisionnumbers = Helpers.GetDivisionNumbers();
                var firstnumber = divisionnumbers[0];
                var secondnumber = divisionnumbers[1];

                Console.WriteLine($"{firstnumber} / {secondnumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstnumber / secondnumber)
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
                if (i == 4)
                {
                    Console.WriteLine($"Game Over. Your final score is {score}. Press any key to return to the menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, "Division");
        }

    }
}
