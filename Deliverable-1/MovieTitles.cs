using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    public class MovieTitles
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine("There are 12 Movies in this list.");

            List<MovieLab> list = new List<MovieLab>();
            list.Add(new MovieLab("IT", "Horror"));
            list.Add(new MovieLab("Bulbbul", "Horror"));
            list.Add(new MovieLab("The Nun", "Horror"));
            list.Add(new MovieLab("Dead Silence", "Horror"));
            list.Add(new MovieLab("LIFE", "Drama"));
            list.Add(new MovieLab("Enough", "Drama"));
            list.Add(new MovieLab("Coach Carter", "Drama"));
            list.Add(new MovieLab("Jodhaa Akbar", "Drama"));
            list.Add(new MovieLab("Monsters v Aliens", "Animation"));
            list.Add(new MovieLab("One Piece RED", "Animation"));
            list.Add(new MovieLab("Howls Moving Castle", "Animation"));
            list.Add(new MovieLab("Monster House", "Animation"));
            list.Add(new MovieLab("Sorry to Bother you", "Sci-Fi"));
            list.Add(new MovieLab("Resident Evil", "Sci-Fi"));
            list.Add(new MovieLab("Spaceballs", "Sci-Fi"));
            list.Add(new MovieLab("Transformers: Revenge of the Fallen", "Sci-Fi"));


            bool userExit = false;
            do
            {
                Console.WriteLine("Would you like to see the full movie list?");

                string userRes2 = Console.ReadLine();
                if (userRes2 == "Y".ToLower() || userRes2 == "Yes".ToLower())
                {
                    foreach (MovieLab item in list)
                    {
                        Console.WriteLine($"{item.title}, {item.category}");
                    }
                }

                Console.WriteLine("What genre are you interested in? Please choose from: Animation, Drama, Horror, or Sci-Fi");
                string userRes1 = Console.ReadLine();
                if (userRes1 == "Animation".ToLower() || userRes1 == "Drama".ToLower() || userRes1 == "Horror".ToLower() || userRes1 == "Sci-Fi".ToLower() || userRes1 == "SciFi".ToLower())
                {
                    int x = 1;
                    string userRes3 = "";
                    foreach (MovieLab movie in list)
                    {
                        if (movie.category.ToLower().Equals(userRes1.ToLower()))
                        {
                            Console.WriteLine("" + (x++) + "." + movie.title + " is" + " " + movie.category);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again");
                    break;

                }

                Console.Write("Would you like to continue?");
                string userRes4 = Console.ReadLine();
                if (userRes4 == "y" || userRes4 == "yes")
                {
                    Console.WriteLine("Please add a movie you like to the list:");
                    string userRes5 = Console.ReadLine();
                    Console.WriteLine("What genre?");
                    string userRes6 = Console.ReadLine();
                    list.Add(new MovieLab(userRes5, userRes6));

                    Console.WriteLine("Thank you for the new movie!");
                    foreach (MovieLab item in list)
                    {
                        Console.WriteLine($"{item.title}, {item.category}");

                    }

                }
                else
                {
                    break;
                }

                Console.WriteLine("Would you like to start again?");
                string userRes7 = Console.ReadLine();
                if (userRes7 == "y" || userRes7 == "yes")
                {
                    userExit = true;
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    userExit = false;
                }

            } while (userExit);
        }
    }
}
