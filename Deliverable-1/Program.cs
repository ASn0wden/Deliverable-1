using System;
using System.Collections.Generic;
using System.Text;
namespace Deliverable1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OrderSandwich();
        }
        public static void OrderSandwich()
        {
            Console.WriteLine("How many people are we making PB&J sandwiches for?");
            int number = int.Parse(Console.ReadLine());

            int neededSlices = 2 * number;
            int neededPeanutButter = 2 * number;
            int neededJelly = 4 * number;

            int finalLoaves = (int)Math.Ceiling((double)neededSlices / 28);
            int finalPeanutButter = (int)Math.Ceiling((double)neededPeanutButter / 32);
            int finalJelly = (int)Math.Ceiling((double)neededJelly / 48);

            Console.WriteLine("You need:");
            Console.WriteLine("{0} slices of bread", neededSlices);
            Console.WriteLine("{0} tablespoons of peanut butter", neededPeanutButter);
            Console.WriteLine("{0} teaspoons of Jelly", neededJelly);

            Console.WriteLine("Which is...");
            Console.WriteLine("{0} Loaves of bread", finalLoaves);
            Console.WriteLine("{0} Jars of peanut butter", finalPeanutButter);
            Console.WriteLine("{0} Jars of Jelly", finalJelly);

            Console.WriteLine("Would you like to restart? Enter yes to continue, or enter any other key to exit");
            string str1 = Console.ReadLine();

            if (str1.Equals("yes"))
            {
                OrderSandwich();
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}