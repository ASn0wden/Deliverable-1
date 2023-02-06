using System.Diagnostics.Metrics;
using System.Globalization;
bool userEscape = false;
do
{
    Console.WriteLine("Enter a sentence:");
    string userSen = Console.ReadLine();
    string[] splitResult = userSen.Split(' ');
    for (int i = 0; i < splitResult.Length; i++)
    {
        Console.WriteLine(splitResult[i]);
    }
    Console.WriteLine("Would you like to Continue?");
    string userRes = Console.ReadLine();
    if (userRes == "yes" || userRes == "y")
    {
        userEscape = true;
    }
    else
    {
        Console.WriteLine("Thanks for playing!");
        userEscape = false;
    }
} while (userEscape);

Console.WriteLine("\n");// a little breaky-break

bool userGetaway = false;
do
{
    Console.WriteLine("Please enter some text:");
    string userAns1 = Console.ReadLine();
    Console.WriteLine("you have entered:" + userAns1);
    Console.WriteLine("Would you like to continue?");
    string userRes1 = Console.ReadLine();
    if (userRes1 == "yes" || userRes1 == "y")
    {
        userGetaway = true;
    }
    else
    {
        Console.WriteLine("Goodbye!");
        userGetaway = false;
        break;
    }
    Console.WriteLine("enter some text:");
    string userAns2 = Console.ReadLine();
    Console.WriteLine("you have entered:" + userAns1 + " " + userAns2);
    Console.WriteLine("Would you like to continue?");
    string userRes2 = Console.ReadLine();
    if (userRes2 == "yes" || userRes2 == "y")
    {
        userGetaway = true;
    }
    else
    {
        Console.WriteLine("Goodbye!");
        userGetaway = false;
        break;
    }
    Console.WriteLine("enter some text:");
    string userAns3 = Console.ReadLine();
    Console.WriteLine("you have entered:" + userAns1 + " " + userAns2 + " " + userAns3);
    Console.WriteLine("Would you like to continue?");
    string userRes3 = Console.ReadLine();
    if (userRes3 == "yes" || userRes3 == "y")
    {
        userGetaway = true;
    }
    else
    {
        Console.WriteLine("Goodbye!");
        userGetaway = false;
        break;
    }
    Console.WriteLine("enter some text:");
    string userAns4 = Console.ReadLine();
    Console.WriteLine("you have entered:" + userAns1 + " " + userAns2 + " " + userAns3 + " " + userAns4);
    Console.WriteLine("Would you like to continue?");
    string userRes4 = Console.ReadLine();
    if (userRes4 == "yes" || userRes4 == "y")
    {
        userGetaway = true;
    }
    else
    {
        Console.WriteLine("Goodbye!");
        userGetaway = false;
        break;
    }
    Console.WriteLine("enter some text:");
    string userAns5 = Console.ReadLine();
    Console.WriteLine("you have entered:" + userAns1 + " " + userAns2 + " " + userAns3 + " " + userAns4 + " " + userAns5);
    Console.WriteLine("Would you like to continue?");
    string userRes5 = Console.ReadLine();
    if (userRes5 == "yes" || userRes5 == "y")
    {
        userGetaway = true;
    }
    else
    {
        Console.WriteLine("Goodbye!");
        userGetaway = false;
        break;
    }
    Console.WriteLine("enter some text:");
    string userAns6 = Console.ReadLine();
    Console.WriteLine("you have entered:" + userAns1 + " " + userAns2 + " " + userAns3 + " " + userAns4 + " " + userAns5 + " " + userAns6);
    Console.WriteLine("Would you like to continue?");
    string userRes6 = Console.ReadLine();
    if (userRes6 == "yes" || userRes6 == "y")
    {
        userGetaway = true;
    }
    else
    {
        Console.WriteLine("Goodbye!");
        userGetaway = false;
        break;
    }
    Console.WriteLine("enter some text:");
    string userAns7 = Console.ReadLine();
    Console.WriteLine("you have entered:" + userAns1 + " " + userAns2 + " " + userAns3 + " " + userAns4 + " " + userAns5 + " " + userAns6 + " " + userAns7);
    Console.WriteLine("Would you like to continue?");
    string userRes7 = Console.ReadLine();
    if (userRes7 == "yes" || userRes7 == "y")
    {
        Console.WriteLine("Lol sike! This is the end.");
        userGetaway = false;
        break;
    }
    else
    {
        Console.WriteLine("Goodbye!");
        userGetaway = false;
        break;
    }
} while (userGetaway);