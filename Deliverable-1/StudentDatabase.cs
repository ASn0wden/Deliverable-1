// Create 3 Arrays with student information

//Array 1: Student Name

bool userLeave = false;
do
{
    string[] names = new string[10];

    names[0] = "Kennedi";
    names[1] = "Londyn";
    names[2] = "Jaxson";
    names[3] = "Pearce";
    names[4] = "Payton";
    names[5] = "Patrice";
    names[6] = "Amir";
    names[7] = "Marley";
    names[8] = "George";
    names[9] = "Andrew";

    Console.WriteLine("Welcome! Please enter a number 0-9 to access the database");
    int userInput = int.Parse(Console.ReadLine());

    if (userInput >= 0 && userInput <= 9)
    {
        Console.WriteLine($"Student {userInput} is {names[userInput]}");
    }
    else
    {
        Console.WriteLine("Invalid number selected, please try again.");
        break;
    }

    Console.WriteLine("Would you like to see the student list?");
    string userResponse = Console.ReadLine();

    if (userResponse == "y" || userResponse == "yes")
    {
        for (int i = 0; i < names.Length; i++)
        {
            int userInt = i + 1;
            Console.WriteLine(userInt + "." + names[i]);
        }
    }
    else
    {
        Console.WriteLine("ok, lets continue.");
    }
    Console.WriteLine("\n");
    
    //array 2 & 3 - Hometown and Favorite food
    
    string[] hometown = { "Raleigh", "Greensboro", "Jamestown", "Belleville", "Canton", "Washington D.C.", "Detroit", "Washington D.C.", "Detroit", "Grand Blanc" };
    string[] food = { "Salad", "Fries", "Nuggets", "Pizza", "Hamburger", "Cheeseburger", "Fruit", "Cheese", "Turkey", "Peanut butter" };

    Console.WriteLine($"Would you like to know {names[userInput]}'s hometown or favorite Food?");
    string userChoice = Console.ReadLine();
    if (userChoice.Contains("town"))
    {
        Console.WriteLine($"{names[userInput]}'s hometown is {hometown[userInput]}");
    }
    else if (userChoice.Contains("food"))
    {
        Console.WriteLine($"{names[userInput]}'s favorite food is {food[userInput]}");
    }

    Console.WriteLine("\n");

    Console.WriteLine("Would you like to learn about another student? y - yes or n - no");
    string userAns = Console.ReadLine();
    if (userAns == "y" || userAns == "yes")
    {
        userLeave = true;
    }
    else
    {
        Console.WriteLine("thank you!");
        userLeave = false;
    }

} while (userLeave);