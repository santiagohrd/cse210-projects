using System.ComponentModel;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
         Console.WriteLine($"Prompt: {_promptText}");
         Console.WriteLine(_entryText);
    }
}