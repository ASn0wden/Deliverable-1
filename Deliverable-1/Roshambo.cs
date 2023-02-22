namespace RoshamboLab
{
    public class RockPaperScissors
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's play Roshambo!");

            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            HumanPlayer humanPlayer = new HumanPlayer();
            humanPlayer.Name = name;

            Console.WriteLine("\n");
            Player challenger = null;
            while (challenger == null)
            {
                Console.WriteLine("Please pick your opponent: RockPlayer or RandomPlayer?");
                string input = Console.ReadLine();

                if (input.ToLower() == "rockplayer" || input.ToLower() == "rock")
                {
                    challenger = new RockPlayer();
                }
                else if (input.ToLower() == "randomplayer" || input.ToLower() == "random")
                {
                    challenger = new RandomPlayer();
                }
                else
                {
                    Console.WriteLine("Invalid selection. Let's try again :)");
                }
            }

            while (true)
            {                
                Roshambo humanChoice = humanPlayer.GenerateRoshambo();
                Roshambo opponentChoice = challenger.GenerateRoshambo();

                Console.WriteLine($"{humanPlayer.Name} chose {humanChoice}.");
                Console.WriteLine($"{challenger.GetType().Name} chose {opponentChoice}.");
                                
                if (humanChoice == opponentChoice)
                {
                    Console.WriteLine("Tie!");
                }
                else if ((humanChoice == Roshambo.Rock && opponentChoice == Roshambo.Scissors) ||
                         (humanChoice == Roshambo.Paper && opponentChoice == Roshambo.Rock) ||
                         (humanChoice == Roshambo.Scissors && opponentChoice == Roshambo.Paper))
                {
                    Console.WriteLine($"{humanPlayer.Name} wins!");
                }
                else
                {
                    Console.WriteLine($"{challenger.GetType().Name} wins!");
                }

                Console.WriteLine("\n");
                Console.WriteLine("Would you like to play again?");
                string playAgainInput = Console.ReadLine();
                if (playAgainInput.ToLower() != "y" || playAgainInput.ToLower() != "yes")
                {
                    break;
                }
            }

        }
    
    }

}
