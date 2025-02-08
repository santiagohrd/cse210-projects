using System.ComponentModel;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
    {
    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        DateTime currentTime = DateTime.Now;

        while (DateTime.Now < futureTime)
        {
            Console.Write($"\nBreath in...");
            ShowCountDown(5);       
            
            Console.Write($"\nBreath out...");
            ShowCountDown(5);            
        }
    }


}