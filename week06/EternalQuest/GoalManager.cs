using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals;

    private int _score;

    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }

    public void Start()
    {
        
        DisplayPlayerInfo();

        List<string> menuOptions = new List<string>
            {
                "Create New Goal",
                "List Goals",
                "Save Goals",
                "Load Goals",
                "Record Event",
                "Quit"
            };

        int option = 0;

        while (option != 6)
    {
        Console.WriteLine("\nMenu Options: ");
        for (int i = 0; i < menuOptions.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {menuOptions[i]}");
        }

        Console.Write("Select a choice from the menu: ");
        string selectedOption = Console.ReadLine();

        if (!int.TryParse(selectedOption, out option) || option < 1 || option > 6)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
            continue;
        }

        switch (option)
        {
            case 1:
                CreateGoal();
                break;

            case 2:
                ListGoalDetails();
                break;

            case 3:
                Console.Write("Enter file name to save: ");
                string saveFile = Console.ReadLine();
                SaveGoals(saveFile);
                Console.WriteLine("Goals saved successfully.");
                break;

            case 4:
                Console.Write("Enter file name to load: ");
                string loadFile = Console.ReadLine();
                LoadGoals(loadFile);
                Console.WriteLine("Goals loaded successfully.");
                break;

            case 5:
                RecordEvent();
                Console.WriteLine($"Your current score is: {_score}");
                break;

            case 6:
                Console.WriteLine("Exiting the program...");
                return;
        }
    }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points!");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");

        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetShortName()}");
            index++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }

        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");

        string input = Console.ReadLine();
        if (!int.TryParse(input, out int goalType) || goalType < 1 || goalType > 3)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
            return;
        }

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter point value: ");
        string points = Console.ReadLine();

        Goal newGoal = null;

        switch (goalType)
        {
            case 1:
                newGoal = new SimpleGoal(name, description, points);
                break;
            case 2:
                newGoal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("Enter target completions: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new CheckListGoal(name, description, points, target, bonus);
                break;
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine("Goal created successfully!");
        }
    }

    public void RecordEvent()
    {
       
        Console.WriteLine("Which goal did you accomplish?");

    for (int i = 0; i < _goals.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
    }

    Console.Write("Enter the number of the goal: ");
    if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
    {
        Goal selectedGoal = _goals[goalIndex - 1];

        int pointsEarned = int.Parse(selectedGoal.GetPoints());

        selectedGoal.RecordEvent();

        if (selectedGoal is CheckListGoal checklistGoal && checklistGoal.IsComplete())
        {
            pointsEarned += checklistGoal.GetBonus();
        }

        _score += pointsEarned;

        Console.WriteLine($"You earned {pointsEarned} points. Your current score is: {_score}");
    }
    }

    public void SaveGoals(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string file)
    {
        _goals.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            if (parts.Length < 2) continue; 

            string typeOfGoal = parts[0];
            string[] data = parts[1].Split(","); 

            string name = data[0];
            string description = data[1];
            string points = data[2];

            Goal goal = null;

            if (typeOfGoal == "SimpleGoal")
        {
            bool isComplete = bool.Parse(data[3]); 
            goal = new SimpleGoal(name, description, points);
        }
        else if (typeOfGoal == "EternalGoal")
        {
            goal = new EternalGoal(name, description, points);
        }
        else if (typeOfGoal == "ChecklistGoal")
        {
            int bonus = int.Parse(data[3]);
            int target = int.Parse(data[4]);
            int completed = int.Parse(data[5]);
            
            CheckListGoal checklistGoal = new CheckListGoal(name, description, points, target, bonus);
            for (int i = 0; i < completed; i++)
            {
                checklistGoal.RecordEvent();
            }
            goal = checklistGoal;
        }

        if (goal != null)
        {
            _goals.Add(goal);
        }
            
        }
    }

    
}