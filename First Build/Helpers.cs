using First_Build.Models;

namespace First_Build
{
    internal class Helpers
    {
        internal static List<game> games = new List<game>();
        private static string gameType;

        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Score History");
            Console.WriteLine("-----------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.date} - {game.type}: {game.score}");
            }
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadLine();
        }
        internal static void AddToHistory(int GameScore, string v)
        {
            games.Add(new game
            {
                date = DateTime.Now,
                score = GameScore,
                type = gameType
            });
        }

        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstnumber = random.Next(1, 99);
            var secondnumber = random.Next(1, 99);

            var result = new int[2];


            while (firstnumber % secondnumber != 0)
            {
                firstnumber = random.Next(1, 99);
                secondnumber = random.Next(1, 99);

            }
            result[0] = firstnumber;
            result[1] = secondnumber;

            return result;
        }
    }
}
