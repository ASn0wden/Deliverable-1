using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Roller
{
    public class DiceRoller1
    {
        //public static Random random = new Random();

        public static int RollDie6()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }

        public static string Roll(int side, int sides1)
        {

            do
            {
                //bool realNum = false;

                Console.WriteLine("Hello, please enter the number of sides on your dice to begin: ");
                int number = int.Parse(Console.ReadLine());

                //if (realNum == true)
                //{
                if (number < 4)
                {
                    Console.WriteLine("Invalid number of sides, please try again.");
                    Console.WriteLine("Hello, please enter the number of sides on your dice to begin: ");
                    number = int.Parse(Console.ReadLine());
                }
                else if (number >= 4)
                {
                    Console.WriteLine("The number user entered is: " + number);
                    Console.WriteLine("Please press Enter to roll.");
                    Console.ReadLine();
                }
                int dice1 = RollDie6();
                int dice2 = RollDie6();
                Console.WriteLine("First die: " + dice1);
                Console.WriteLine("Second die: " + dice2);
                int totalRoll = (dice1 + dice2);
                Console.WriteLine("Sum of die: " + totalRoll);

                if (dice1 == 1 && dice2 == 1)
                {
                    Console.WriteLine("Snake Eyes!");
                }
                else if ((dice1 == 1 && dice2 == 2) || (dice1 == 2 && dice2 == 1))
                {
                    Console.WriteLine("Ace Deuce!");
                }
                else if (dice1 == 6 && dice2 == 6)
                {
                    Console.WriteLine("Box Cars!");
                }
                else if (dice1 + dice2 == 7 || dice1 + dice2 == 3 || dice1 + dice2 == 12)
                {
                    Console.WriteLine("Craps!");
                }
                else if (dice1 + dice2 == 7 || dice1 + dice2 == 11)
                {
                    Console.WriteLine("Win!");
                }

                Console.WriteLine("Would you like to play again?");
                string userAns = Console.ReadLine();
                if (userAns == "y" || userAns == "yes")
                {
                    Roll(side, sides1);
                }

                return "";
            } while (false);

        }

    }
}


