using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_Blockbuster
{
    class DVD : Movie
    {
        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes):base(Title, Category, RunTime, Scenes )
        {

        }

        public override void Play()
        {
            bool validEntry = false;
            bool watchMore = true;
            string input = "";
            int index = 0;
            string input2 = "";

            while (watchMore)
            {
                Console.WriteLine($"{Title} Scene List");

                PrintScenes();

                Console.Write("Please enter the number of the scene you'd like to watch: ");


                while (!validEntry)
                {
                    input = Console.ReadLine();

                    while (!int.TryParse(input, out int n))
                    {
                        Console.Write("Please enter a valid scene number: ");
                        input = Console.ReadLine();
                    }

                    index = int.Parse(input);

                    if (index < 1 || index > Scenes.Count)
                    {
                        Console.Write("Please enter a valid scene number: ");
                    }
                    else
                    {
                        index = index - 1;
                        validEntry = true;
                    }
                }

                Console.Clear();
                Console.WriteLine("Begin Scene Playback");
                Console.WriteLine(Scenes[index]);

                Console.Write("\nWould you like to watch another scene? (y/n) ");
                input2 = Console.ReadLine().ToLower();

                while (input2 != "y" && input2 != "n")
                {
                    Console.Write("Invalid input.  Please enter (y/n): ");
                    input2 = Console.ReadLine().ToLower();
                }

                if (input2 == "n")
                {
                    watchMore = false;
                    Console.WriteLine("Thanks for watching!");
                }
                else if (input2 == "y")
                {
                    watchMore = true;
                    validEntry = false;
                    Console.Clear();
                }
            }
        }

    }
}
