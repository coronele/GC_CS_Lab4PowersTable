using System;

namespace Lab_4___Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowTitle();
            int userInt = GetUserInt("Enter an integer for us to square/cube.\n");
            ShowPowersTable(userInt);

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
            SetInputColor();
            int input;
            while (!(int.TryParse(message, out input)))
            {
                SetOutputColor();
                Console.Write("Please enter a valid integer: ");
                message = Console.ReadLine();
            }
            Console.WriteLine(input);
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

            string square, cube;
            
            for (int i=1; i <= UserInt; i++)
            {
                square = (i * i).ToString();
                cube = (i * i * i).ToString();
                Console.WriteLine($"{i}  {square}   {cube}");
            }

        }
    }
}

