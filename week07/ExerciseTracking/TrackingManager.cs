public class TrackingManaher
{

    private List<Activity> _activities = new List<Activity>();

    public List<Activity> GetActivities()
{
    return _activities;
}


    public void Start()
    {
        List<string> menuOptions = new List<string>
            {
                "List Activities",
                "Swimming",
                "Cycling",
                "Running",
                "Quit"
            };

        int option = 0;

        while (option != 5)
        {
            Console.WriteLine("\nMenu Options: ");
            for (int i = 0; i < menuOptions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {menuOptions[i]}");
            }

            TrackActivity(option);
            
        }
    }

    public void TrackActivity(int userOption)
    {
        Activity newActivity = null;
        int option = 0;
        
        Console.Write("What activity did you accomplish today? ");
        string activity = Console.ReadLine();
        option = int.Parse(activity);

        if (option == 1)
        {
            DisplayActivities();
        }
        
        else if (option == 2)
        {
            Console.Clear();
            Console.WriteLine("Swimming\n");

            DateTime date = DateTime.Now;

            Console.Write("Duration (min): ");
            int duration = int.Parse(Console.ReadLine());

            Console.Write("Laps: ");
            int laps = int.Parse(Console.ReadLine());

            newActivity = new Swimming(date.ToString("dd MMM yyyy"), duration, laps);

        }

        else if (option == 3)
        {
            Console.Clear();
            Console.WriteLine("Cycling\n");

            DateTime date = DateTime.Now;

            Console.Write("Duration (min): ");
            int duration = int.Parse(Console.ReadLine());

            Console.Write("Speed (km/h): ");
            int speed = int.Parse(Console.ReadLine());

            newActivity = new Cycling(date.ToString("dd MMM yyyy"), duration, speed);

        }

        else if (option == 4)
        {
            Console.Clear();
            Console.WriteLine("Running\n");
            DateTime date = DateTime.Now;

            Console.Write("Duration (min): ");
            int duration = int.Parse(Console.ReadLine());

            Console.Write("Distance (km): ");
            int distance = int.Parse(Console.ReadLine());

            newActivity = new Running(date.ToString("dd MMM yyyy"), duration, distance);

        }

        if (newActivity != null)
        {
            _activities.Add(newActivity);
        }

    }

    public void DisplayActivities()
    {
        Console.WriteLine("The activities are:");

        int index = 1;
        foreach (var activity in _activities)
        {
            Console.WriteLine($"{activity.GetSummary()}");
            index++;
        }
    }
}