using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red", 12);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Blue", 8, 10);
        shapes.Add(rectangle);

        Circle circle = new Circle("Black", 6);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} {shape}");
            Console.WriteLine($"Area: {shape.GetArea()} \n");
        }
    }
}