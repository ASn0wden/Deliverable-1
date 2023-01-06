using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_1
{
 
    public class Deliverable2
    {
        public static void main(string[] args)
        {


            Console.WriteLine("Hello. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.");
            int stn = int.Parse(Console.ReadLine());

            decimal buffet = 9.99m;

            if (stn > 6)
            {
                Console.WriteLine("Im sorry, can only seat parties up to 6. Have a nice day.");
            }
            else

            {
                Console.WriteLine("A table for 6! Please follow me and take a seat. Let's get everyone started with drinks, we've got water or coffee.");
                string ps = Console.ReadLine();

                while (true)
                {
                    Console.WriteLine("Alright, person number 1, water or coffee?");
                    string ps1 = Console.ReadLine();
                    if (ps1 == "water")
                    {
                        Console.WriteLine("Water, good choice!");
                        break;
                    }
                    else if (ps1 == "coffee")
                    {
                        Console.WriteLine("Coffee, okay!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid choice");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Alright, person number 2, water or coffee?");
                    string ps2 = Console.ReadLine();
                    if (ps2 == "water")
                    {
                        Console.WriteLine("Water, good choice!");
                        break;
                    }
                    else if (ps2 == "coffee")
                    {
                        Console.WriteLine("Coffee, okay!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid choice");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Alright, person number 3, water or coffee?");
                    string ps3 = Console.ReadLine();
                    if (ps3 == "water")
                    {
                        Console.WriteLine("Water, good choice!");
                        break;
                    }
                    else if (ps3 == "coffee")
                    {
                        Console.WriteLine("Coffee, okay!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid choice");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Alright, person number 4, water or coffee?");
                    string ps4 = Console.ReadLine();
                    if (ps4 == "water")
                    {
                        Console.WriteLine("Water, good choice!");
                        break;
                    }
                    else if (ps4 == "coffee")
                    {
                        Console.WriteLine("Coffee, okay!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid choice");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Alright, person number 5, water or coffee?");
                    string ps5 = Console.ReadLine();
                    if (ps5 == "water")
                    {
                        Console.WriteLine("Water, good choice!");
                        break;
                    }
                    else if (ps5 == "coffee")
                    {
                        Console.WriteLine("Coffee, okay!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid choice");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Alright, person number 6, water or coffee?");
                    string ps6 = Console.ReadLine();
                    if (ps6 == "water")
                    {
                        Console.WriteLine("Water, good choice!");
                        break;
                    }
                    else if (ps6 == "coffee")
                    {
                        Console.WriteLine("Coffee, okay!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("invalid choice");
                    }
                }

                decimal totalbuffet = stn * buffet;
                int CoffeeOrdered = 2;
                int costOfCoffee = 2;
                decimal totalCoffee = 2 * 2.00m;
                int costOfWater = 0;
                decimal total = totalbuffet + totalCoffee + costOfWater;



                Console.WriteLine("Here's your bill! Total price: " + total);
            }

        }
    }
}
