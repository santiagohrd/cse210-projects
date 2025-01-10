using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("What is your grade percentage?");
        String gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter;
        if (grade >= 90)
        {
            letter = "A";
            Console.WriteLine($"{letter}");
        }
        else if (grade >= 80)
        {
            letter = "B";
            Console.WriteLine($"{letter}");
        }
        else if (grade >= 70)
        {
            letter = "C";
            Console.WriteLine($"{letter}");
        }
        else if (grade >= 60)
        {
            letter = "D";
            Console.WriteLine($"{letter}");
        }
        else
        {
            letter = "F";
            Console.WriteLine($"{letter}");
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Make an effort the next semester.");
        }
    }
    
}