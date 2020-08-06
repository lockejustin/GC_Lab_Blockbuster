using System;
using System.Collections.Generic;

namespace GC_Lab_Blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster theStore = new Blockbuster();

            string[] menuOptions = { "List Movies", "Check Out Movie", "Buy Merch", "Exit (Please buy some merch before you do!)" };
            int menuChoice = 0;
            bool continueProgram = true;
            bool validEntry = false;
            string input = "";

            while (continueProgram) //continues program until user chooses quit option
            {
                Console.WriteLine("Welcome to the last BlockBuster in existence!\nPlease buy our merch!");
                Console.WriteLine("\nHere is a list of what you can do.");
                for (int i = 0; i < menuOptions.Length; i++)  //writes main menu to console
                {
                    Console.WriteLine($"{i + 1}) {menuOptions[i]}");
                }
                
                
                Console.Write("Please enter the number of what you'd like to do: ");

                while (!validEntry)  //loops until valid integer entry is received 
                {
                    input = Console.ReadLine();

                    while (!int.TryParse(input, out int n))
                    {
                        Console.Write("Please enter a valid menu choice: ");
                        input = Console.ReadLine();
                    }

                    menuChoice = int.Parse(input);

                    if (menuChoice < 1 || menuChoice > menuOptions.Length)
                    {
                        Console.Write("Please enter a valid menu choice: ");
                    }
                    else
                    {
                        validEntry = true;
                    }
                }

                if (menuChoice == 1) //generates list of movies to console
                {
                    Console.Clear();
                    theStore.PrintMovies();
                    Console.WriteLine("Please press any key to return to the main menu.");
                    validEntry = false;
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (menuChoice == 2) //take user to check out menu
                {
                    Console.Clear();
                    theStore.CheckOut();
                    Console.WriteLine("Please press any key to return to the main menu.");
                    validEntry = false;
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (menuChoice == 3) //thanks user for buying some merch
                {
                    Console.Clear();
                    Console.WriteLine("Thank you for buying merch!  We need all the revenue we can get!");
                    Console.WriteLine("Please press any key to return to the main menu.");
                    validEntry = false;
                    Console.ReadKey();
                    Console.Clear();
                }
                else //quits the program
                {
                    Console.Clear();
                    Console.WriteLine("Please come back and rent something soon!  Like, really soon.  We are almost out of money.");
                    continueProgram = false;
                }
            }
        }
    }
}
