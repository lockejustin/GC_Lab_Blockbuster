using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_Blockbuster
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }

        public VHS(string Title, Genre Category, int RunTime, List<string> Scenes, int CurrentTime) : base(Title, Category, RunTime, Scenes)
        {

        }

        public override void Play() //plays the movie from beginning, could not figure out why currentTime value does not pass through
        {
            bool watchMore = true;
            int increment = (RunTime / Scenes.Count);
            string input = "";

            Console.WriteLine(CurrentTime);

            while (watchMore)
            {
                Console.WriteLine("Begin Scene Playback");
                Console.WriteLine($"{Scenes[CurrentTime/increment]}");
                CurrentTime += increment;

                if ((CurrentTime + increment) > RunTime)
                {
                    Console.WriteLine("That's the end of the movie!  Thanks for watching!");
                    break;
                }

                Console.Write("Would you like to continue watching? (y/n) ");
                input = Console.ReadLine();

                while (input != "y" && input != "n")
                {
                    Console.Write("Invalid input.  Please enter (y/n): ");
                    input = Console.ReadLine().ToLower();
                }

                if (input == "y")
                {
                    watchMore = true;
                    Console.Clear();
                }
                else if (input == "n")
                {
                    watchMore = false;
                }


            }
        }

        public void PlayWholeMovie()
        {
            Console.WriteLine($"Press any key to begin playback of {Title}.");
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i}");
                Console.WriteLine($"{Scenes[i]}");
                Console.WriteLine("Press any key to move on to the next scene.");
                Console.ReadKey();
                Console.Clear();
            }
        }

            public void Rewind()
        {
            CurrentTime = 0;
        }

    }
}
