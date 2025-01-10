using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        // Console.WriteLine("What is the magic number?");
        // string number = Console.ReadLine();
        // int magicNumber = int.Parse(number);


        int magicGuess = 0;

        while (magicGuess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();
            magicGuess = int.Parse(guess);

            magicGuess = int.Parse(guess);
                if (magicGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (magicGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
        }


    }
}