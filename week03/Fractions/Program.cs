using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        Console.WriteLine("First constructor:");
        Console.WriteLine($"Top value: {fraction1.GetTop()}");
        Console.WriteLine($"Bottom value: {fraction1.GetBottom()}");

        Console.WriteLine("Second constructor:");
        fraction2.SetTop(3);
        Console.WriteLine("Top value: " + fraction2.GetTop());

        Console.WriteLine("Third constructor:");

        fraction3.SetTop(5);
        fraction3.SetBottom(4);

        Console.WriteLine("Top value: " + fraction3.GetTop());
        Console.WriteLine("Bottom value: " + fraction3.GetBottom());

        Console.WriteLine("Methods:");
        Console.WriteLine(fraction1.GetFractionString()) ;

        Console.WriteLine(fraction3.GetDecimalValue());

    }
}