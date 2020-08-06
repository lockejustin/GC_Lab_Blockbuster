using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_Blockbuster
{
    class Blockbuster
    {
        public List<Movie> Movies = new List<Movie>
            {
                new DVD("Star Wars", Genre.Action, 100, new List<string> {"Title Scrawl/Fanfare", "Vader kills some dudes", "Use the Force!", "Run...Run...Run..Jump!", "Seagulls, stop it now!","Directed by George Lucas" } ),
                new DVD("Avengers", Genre.Drama, 120, new List<string>{"Comic Book Style Intro", "Explosions!", "Cap and Tony argue", "Cap and Tony kinda make up", "BIG FIGHT!", "The End"}),
                new DVD("Harry Potter", Genre.Horror, 90, new List<string>{"Fancy Intro - So Magical", "Living Under the Steps(Child Abuse?)", "Off to Hogwarts Again!", "Let's not tell Harry anything!", "Kids defeat some monster they have no business beating", "The End!" }),
                new VHS("The Princess Bride", Genre.Comedy, 120, new List<string>{"Intro - Story Time!", "As you wish", "You killed my father, prepare to die (part1)", "Inconveivable!", "You killed my father, prepare to die (part 2)", "The End"}, 29),
                new VHS("Indiana Jones", Genre.Action, 100, new List<string>{"Intro", "Adventure time!", "The floors on fire!", "And the chair!", "Found the shiny!", "How isn't he dead yet?", "The End!"}, 0),
                new VHS("Alladin", Genre.Romance, 90, new List<string>{"Disney Intro", "Lots of sand", "Is that Robin Williams? (Genie)", "Pauper to Prince", "The monkey turned into an elephant?", "Gilbert Godfreid", "Oh no, the bad guy might win", "Just kidding, bad guy lost", "The End!" }, 0)
            };
        public void PrintMovies()
        {
            Console.WriteLine("MOVIE LIST");
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{i+1}) {Movies[i].Title}");
            }
        }

        public void CheckOut()
        {
            string input = "";
            int choice = 0;
            bool validEntry = false;
            
            PrintMovies();
            Console.Write("Please enter the number of the movie you'd like to check out: ");

            while (!validEntry)
            {
                input = Console.ReadLine();

                while (!int.TryParse(input, out int n))
                {
                    Console.Write("Please enter a valid movie number: ");
                    input = Console.ReadLine();
                }

                choice = int.Parse(input);

                if (choice < 1 || choice > Movies.Count)
                {
                    Console.Write("Please enter a valid movie number: ");
                }
                else
                {
                    choice = choice - 1;
                    validEntry = true;
                }
            }


            Console.Clear();
            Console.WriteLine($"Thanks for checking out the following movie:");
            Movies[choice].PrintInfo();

            Console.Write("Would you like to watch your movie? (y/n) ");
            input = Console.ReadLine().ToLower();

            while (input != "y" && input != "n")
            {
                Console.Write("Invalid input.  Please enter (y/n): ");
                input = Console.ReadLine().ToLower();
            }

            if (input == "y")
            {
                Console.Clear();
                Movies[choice].Play();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Thank you for checking out {Movies[choice].Title}.");
            }
        }
    }
}
