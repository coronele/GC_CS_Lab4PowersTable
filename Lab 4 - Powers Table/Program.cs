﻿using System;

namespace Lab_4___Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueEntry;

            // This shows the program title
            ShowTitle();

            do
            {
                // Prompt for and receive input
                int userInt = GetUserInt("We will need an integer to square/cube.\n");
                
                // Display powers table
                ShowPowersTable(userInt);
                
                // Prompt to repeat program
                continueEntry = TryAgain();
            }
            while (continueEntry == "y");
        }
        public static string GetUserInput(string message)
        {
            SetOutputColor();
            Console.WriteLine(message);
            SetInputColor();
            string input = Console.ReadLine();
            return input;
        }

        public static int GetUserInt(string message)
        {
            
            // Gets integer for user to process into squares and cubes.  Includes validation.
            SetOutputColor();
            Console.WriteLine(message);
            
            int input;
            
            // input validation
            // Will repeat until valid int is entered.  Will return input (which contains entered int) if input valid.
            while (!(int.TryParse(message, out input)))
            {
                SetOutputColor();
                Console.Write("Please enter a valid integer: ");
                SetInputColor();
                message = Console.ReadLine();
            }
            return input;
        }
        public static void SetInputColor()
        {
            // Method for setting colors for user inputted text
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public static void SetOutputColor()
        {
            // Method for setting colors for default display text
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public static void ShowTitle()
        {
            // This method simply shows the title
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Powers Table\n\n");

        }

        public static void ShowPowersTable(int UserInt)
        {
            // Prints the powers table from 1 to user entered number
            SetOutputColor();

            Console.WriteLine("\n\n  {0,15}      {1,15}       {2,15}", "number", "square", "cube");
            for (int i = 1; i <= UserInt; i++)
            {
                Console.WriteLine("      {0,15}      {1,15}       {2,15}", i, Square(i), Cube(i));
            }
            Console.WriteLine("\n\n");
        }

        public static string TryAgain()
        {
            // Method for running program again.  Passes back to do while loop in main.
            string userChoice = GetUserInput("Would you like to run again? [y/n] ").ToLower();
            while ((userChoice!="y") && (userChoice!="n"))
            {
                userChoice = GetUserInput("Please enter 'y' or 'n'.  Would you like to run again? [y/n] ");
            }
            return userChoice;
        }

        public static int Square(int num)
        {
            // squares value
            return num * num;
        }

        public static int Cube(int num)
        {
            // cubes value
            return num * num * num;
        }
    }
}

