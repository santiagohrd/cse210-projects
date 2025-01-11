using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();

        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        PromptUserName(userName);

        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        int userNumber = int.Parse(number);
        PromptUserNumber(userNumber);


        int squre = SquareNumber(userNumber);

        DisplayResult(userName, squre);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName(string name)
        {
            string userName = name;
            return userName;
        }

        static int PromptUserNumber(int number)
        {
            int userNumber = number;
            return userNumber;
        }

        static int SquareNumber(int number)
        {
            int squareNumber = number * number;
            return squareNumber;
        }

        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }
    }
}