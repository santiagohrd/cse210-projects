using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment1 = new Assignment("Santiago", "Multiplication");
        MathAssignment math1 = new MathAssignment("Santiago", "Multiplication", "7.3", "8-19");
        WritingAssignment write1 = new WritingAssignment("Santiago", "European History", "The Causes of World War II by Mary Waters");

        Console.WriteLine($"{assignment1.GetSummary()}");
        Console.WriteLine(" ");

        Console.WriteLine($"{math1.GetSummary()}");
        Console.WriteLine($"{math1.GetHomeworkList()}");
        Console.WriteLine(" ");

        Console.WriteLine($"{write1.GetSummary()}");
        Console.WriteLine($"{write1.GetWritingInformation()}");
    }
}