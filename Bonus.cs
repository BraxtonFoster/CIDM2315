using System;

namespace Bonus
{
    class HumanPlayer
    {
        private int points;

        public HumanPlayer(int initial)
        {
            points = initial;
        }

        public int GetPoints()
        {
            return points;
        }

        public void WinRound()
        {
            points += 5;
        }

        public void LoseRound()
        {
            points -= 5;
        }

        public string HumanDecision()
        {
            Console.WriteLine("Please input your choice (Rock, Paper, Scissors): ");
            string decision = Console.ReadLine().Trim();
            Console.WriteLine($"--> Your Decision: {decision}");
            return decision;
        }
    }

    class ComputerPlayer
    {
        private static Random random = new Random();

        public string ComputerDecision()
        {
            string[] choices = { "Rock", "Paper", "Scissors" };
            int index = random.Next(choices.Length);
            return choices[index];
        }
    }

    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Rock Paper Scissors, Shoot!!!****");
            HumanPlayer human = new HumanPlayer(5);
            ComputerPlayer computer = new ComputerPlayer();

            while (human.GetPoints() > 0)
            {
                Console.WriteLine($"Your current points: {human.GetPoints()}");

                string humanChoice = human.HumanDecision();
                string computerChoice = computer.ComputerDecision();

                Console.WriteLine($"--> Computer Decision: {computerChoice}");

                if (humanChoice.Equals(computerChoice, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("It's a tie!");
                }
                else if ((humanChoice.Equals("Rock", StringComparison.OrdinalIgnoreCase) && computerChoice == "Scissors") ||
                         (humanChoice.Equals("Paper", StringComparison.OrdinalIgnoreCase) && computerChoice == "Rock") ||
                         (humanChoice.Equals("Scissors", StringComparison.OrdinalIgnoreCase) && computerChoice == "Paper"))
                {
                    Console.WriteLine("You Win!");
                    human.WinRound();
                }
                else
                {
                    Console.WriteLine("You lose!");
                    human.LoseRound();
                }
                 if (human.GetPoints() <= 0)
                {
                    Console.WriteLine("Sorry, you don't have enough points, thanks for playing");
                    break; 
                }

                Console.WriteLine("Play again? Input y to continue, or n to exit");
                string playAgain = Console.ReadLine().Trim().ToLower();
                if (playAgain != "y")
                {
                    break;
                }

                Console.WriteLine($"Your points: {human.GetPoints()}");
            }

            Console.WriteLine("Thank you for playing!");
        }
    }
}
