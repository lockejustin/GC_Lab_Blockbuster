using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_Blockbuster
{
    abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, Genre Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        public virtual void PrintInfo() //prints title, category, and runtime for movie
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Run time: {RunTime}");
        }
        public void PrintScenes() //prints each scene of the movie in order
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Scenes[i]}");
            }
        }

        public abstract void Play();
    }
}
