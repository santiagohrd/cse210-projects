public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(int duration) : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _count = 0;
    }


    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write($"You may begin in: ");
        ShowCountDown(5);

        Console.WriteLine();
        List<string> userResponses = GetListFromUSer();

        _count = userResponses.Count;
        Console.WriteLine($"\nYou listed {_count} items!");
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int promptIndex = random.Next(_prompts.Count);

        Console.WriteLine($"\n---{_prompts[promptIndex]}---");

    }

    public List<string> GetListFromUSer()
    {
        List<string> responses = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        DateTime currentTime = DateTime.Now;
        
        while (DateTime.Now < futureTime)
        {
            Console.Write(">");
            string userResponse = Console.ReadLine();
            
            responses.Add(userResponse);
        }
        return responses;
    }
}