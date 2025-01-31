using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("John", 3, 16);
        string text = "¡Oh, gloria inmarcesible! ¡Oh, júbilo inmortal!¡En surcos de dolores El bien germina ya! ¡Cesó la horrible noche! La libertad sublime Derrama las auroras De su invencible luz. La humanidad enter, Que entre cadenas gime, Comprende las palabras Del que murió en la cruz";

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.isCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}