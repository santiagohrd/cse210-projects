using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
       
        int newNumber = -1;

        while (newNumber != 0)
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            newNumber = int.Parse(number);

            numbers.Add(newNumber);
        }

        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
        
    }
}