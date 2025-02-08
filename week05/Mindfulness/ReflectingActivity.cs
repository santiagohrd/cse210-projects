public class ReflectingActivity : Activity
{
    private List<string>  _prompts;
    private List<string> _questions;

    public ReflectingActivity(int duration) : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        Console.WriteLine("Consider the following prompt: ");

        DisplayPrompt();

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        string pressKey = null;

        while (true)
        {
            ShowSpinner(4);
            pressKey = Console.ReadLine();

            if (string.IsNullOrEmpty(pressKey))
            {
                break;
            }
        }
    
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in...");
        ShowCountDown(5);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        DateTime currentTime = DateTime.Now;

        while (DateTime.Now < futureTime)
        {
            foreach (string question in _questions)
            {     
                DisplayQuestions();
                ShowSpinner(6);
                break;
            }
        }
        
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int promptIndex = random.Next(_prompts.Count);

        return $"\n---{_prompts[promptIndex]}---";
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int questionIndex = random.Next(_questions.Count);
        string selectedQuestion = _questions[questionIndex];

        // _questions.RemoveAt(questionIndex);
        return $"\n>{selectedQuestion}";


    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.Write($"\n{GetRandomQuestion()}");
    }
}