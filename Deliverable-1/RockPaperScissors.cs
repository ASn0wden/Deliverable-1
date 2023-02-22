using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    public enum Roshambo
    {
        Rock,
        Paper,
        Scissors
    }

    public abstract class Player
    {
        public string Name { get; set; }
        public Roshambo RoshamboValue { get; set; }

        public abstract Roshambo GenerateRoshambo();
    }

    public class RockPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }

    public class HumanPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Console.WriteLine("Select your Roshambo move:");
            Console.WriteLine("1: Rock");
            Console.WriteLine("2: Paper");
            Console.WriteLine("3: Scissors");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    return Roshambo.Rock;
                case 2:
                    return Roshambo.Paper;
                case 3:
                    return Roshambo.Scissors;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    return GenerateRoshambo();
            }

        }
    }

    public class RandomPlayer : Player
    {
        public Random random;

        public RandomPlayer()
        {
            random = new Random();
        }

        public override Roshambo GenerateRoshambo()
        {
            int randomValue = random.Next(0, 3);
            return (Roshambo)randomValue;
        }
    }

}
