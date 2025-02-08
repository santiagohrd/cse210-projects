public class Activity
{
    private string _name;
    private string _description; 
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration()
    {
        Console.Write("\nHow long, in seconds would you like your session? ");
        string duration = Console.ReadLine();

        _duration = int.Parse(duration  );
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to {_name}");
        Console.WriteLine($"\n{_description}");

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(5);

        Console.WriteLine($"\nYou have complated another {_duration} seconds of the {_name}");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>{"|", "/", "-", "\\", "|", "/", "-", "\\",} ;
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        while (DateTime.Now < endTime)
        {
            foreach (string item in animationStrings)
            {
                Console.Write(item);
                Thread.Sleep(400);
                Console.Write("\b \b");
            }   
            
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)    
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}