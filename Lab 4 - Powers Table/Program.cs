using System;

namespace Lab_4___Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueEntry;

            ShowTitle();

            do
            {
                int userInt = GetUserInt("We will need an integer to square/cube.\n");
                ShowPowersTable(userInt);
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
            SetOutputColor();
            Console.WriteLine(message);
            
            int input;
            
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
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public static void SetOutputColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public static void ShowTitle()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Powers Table\n\n");

        }

        public static void ShowPowersTable(int UserInt)
        {
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
            string userChoice = GetUserInput("Would you like to run again? [y/n] ").ToLower();
            while ((userChoice!="y") && (userChoice!="n"))
            {
                userChoice = GetUserInput("Please enter 'y' or 'n'.  Would you like to run again? [y/n] ");
            }
            return userChoice;
        }

        public static int Square(int num)
        {
            return num * num;
        }

        public static int Cube(int num)
        {
            return num * num * num;
        }
    }
}

